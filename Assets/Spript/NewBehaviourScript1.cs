using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
public class NewBehaviourScript1 : MonoBehaviour
{

    public static int endcount = 0;
    /// 物理剛体
    private Rigidbody physics = null;

    /// 発射方向
    [SerializeField]
    private LineRenderer direction = null;

    /// 最大付与力量
    private const float MaxMagnitude = 3f;

    /// 発射方向の力
    private Vector3 currentForce = Vector3.zero;

    /// メインカメラ
    private Camera mainCamera = null;

    /// メインカメラ座標
    private Transform mainCameraTransform = null;

    /// ドラッグ開始点
    private Vector3 dragStart = Vector3.zero;


    /// 初期化処理
    public void Awake()
    {
        physics = GetComponent<Rigidbody>();
        this.mainCamera = Camera.main;
        this.mainCameraTransform = this.mainCamera.transform;
    }


    /// マウス座標をワールド座標に変換して取得
    private Vector3 GetMousePosition()
    {
        // マウスから取得できないZ座標を補完する
        var position = Input.mousePosition;
        position.z = this.mainCameraTransform.position.z;
        position = this.mainCamera.ScreenToWorldPoint(position);
        position.z = 0;

        return position;
    }

    /// ドラック開始イベントハンドラ
    public void OnMouseDown()
    {
        this.dragStart = this.GetMousePosition();
        this.direction.enabled = true;
        this.direction.SetPosition(0, this.physics.position);
        this.direction.SetPosition(1, this.physics.position);
    }

    /// ドラッグ中イベントハンドラ
    public void OnMouseDrag()
    {
        var position = this.GetMousePosition();
        this.currentForce = position - this.dragStart;
        if (this.currentForce.magnitude > MaxMagnitude * MaxMagnitude)
        {
            this.currentForce *= MaxMagnitude / this.currentForce.magnitude;
        }

        this.direction.SetPosition(0, this.physics.position);
        this.direction.SetPosition(1, this.physics.position + this.currentForce);
    }

    /// ドラッグ終了イベントハン
    public void OnMouseUp()
    {
        this.direction.enabled = false;
        this.Flip(this.currentForce * 10f);
    }


    /// ボールをはじく
    public void Flip(Vector3 force)
    {
        // 瞬間的に力を加えてはじく
        this.physics.AddForce(force, ForceMode.Impulse);
    }

    public void Update()
    {

    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "ded")
        {
            endcount = ScoreManager.Score * 50;
            SceneManager.LoadScene("EndScene");
        }
        if (other.gameObject.tag == "ded2")
        {
            endcount = ScoreManager.Score * 100;
            SceneManager.LoadScene("EndScene");
        }
        if (other.gameObject.tag == "ded3")
        {
            endcount = ScoreManager.Score * 200;
            SceneManager.LoadScene("EndScene");
        }
        if (other.gameObject.tag == "ded4")
        {
            endcount = ScoreManager.Score * 400;
            SceneManager.LoadScene("EndScene");
        }
        if (other.gameObject.tag == "ded5")
        {
           endcount = ScoreManager.Score * 500;
            SceneManager.LoadScene("EndScene");
        }

        if (other.gameObject.tag == "clear")
        {
           endcount = ScoreManager.Score * 1000;
            SceneManager.LoadScene("ClearScene");
        }
    }

}