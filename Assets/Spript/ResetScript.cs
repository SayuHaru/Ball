using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            CameraController.c = 0;
            CameraController.c2 = 0;
            ScoreManager.CountDownTime = 40.0F;
            SceneManager.LoadScene("SampleScene");
        }
    }
}
