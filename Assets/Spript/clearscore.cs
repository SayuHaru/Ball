using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clearscore : MonoBehaviour
{
    GameObject coreText;
    // Start is called before the first frame update
    void Start()
    {
        coreText = GameObject.Find("Text");
    }

    // Update is called once per frame
    void Update()
    {
        coreText.GetComponent<Text>().text = "あなたのScore:" + NewBehaviourScript1.endcount;
    }
}
