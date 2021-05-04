using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endScore : MonoBehaviour
{
    GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("Text");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = "あなたのScore:" + NewBehaviourScript1.endcount;
    }
}
