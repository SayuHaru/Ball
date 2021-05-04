using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tate : MonoBehaviour
{
    private Vector3 last;
    // Start is called before the first frame update
    void Start()
    {
        last = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(last.x, Mathf.Sin(Time.time) * 2 + last.y, last.z);
    }
}
