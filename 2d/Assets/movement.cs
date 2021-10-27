using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        Vector3 change = this.transform.TransformVector(0.1f, 0, 0);
        Vector3 changeVertical = this.transform.TransformVector(0, 0.1f, 0);
        if (Input.GetKey(KeyCode.D))
        {
            
            this.transform.position = this.transform.position + change;

        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position = this.transform.position - change;
        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position = this.transform.position + changeVertical;
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position = this.transform.position - changeVertical;
        }





    }
}
