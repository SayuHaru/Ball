using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
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
        transform.position = new Vector3(Mathf.Sin(Time.time) * 2 +last.x,last.y,last.z);
    }
}
