using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    //public Rigidbody rigidbody;
    public 　static int c = 0;
    public  static int c2 = 0;

    void Start()
    {
        //rigidbody = this.GetComponent<Rigidbody>();
   
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ball = GameObject.Find("Ball").transform.position;
       
        if (ball.y < -4 && c ==0)
        {
            Debug.Log("1st Stage Clear");
            this.transform.position += new Vector3(0, -0.5f, 0);
            if (this.transform.position.y == -8)
            {
                this.transform.position += new Vector3(0, 0.5f, 0);
                c = 1;
            }
        }

        if (ball.y < -13 && c==1)
        {
            Debug.Log("2nd Stage Clear");
            this.transform.position += new Vector3(0, -0.5f, 0);
            if (this.transform.position.y == -28)
            {
                this.transform.position += new Vector3(0, 0.5f, 0);
                c = 2;
            }
        }




        if (ball.y < -36 && c == 2)
        {
            Debug.Log("3rd Stage Clear");
            this.transform.position += new Vector3(0, -0.5f, 0);
            if (this.transform.position.y == -50)
            {
               // Debug.Log(this.transform.position.y);
                this.transform.position += new Vector3(0, 0.5f, 0);
                c = 3;
            }
        }

        if (ball.y < -56 && c == 3)
        {
            Debug.Log("4th Stage Clear");
            this.transform.position += new Vector3(0, -0.5f, 0);
            if (this.transform.position.y == -80)
            {
             //   Debug.Log(this.transform.position.y);
                this.transform.position += new Vector3(0, 0.5f, 0);
                c = 4;
            }
        }




    }
}
