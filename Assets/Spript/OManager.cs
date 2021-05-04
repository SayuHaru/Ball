using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OManager : MonoBehaviour
{
    public GameObject O;
    // Start is called before the first frame update
    void Start()
    {
        O.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ball = GameObject.Find("Ball").transform.position;
        if (ball.y < -80 && ball.x > 9)
        {
            O.SetActive(true);
        }
    }
}
