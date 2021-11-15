using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    // Start is called before the first frame update
    public int direction = 1;
    public static bool active = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        Vector3 moveVertical = this.transform.TransformVector(0, 0.1f, 0);
        if (!active)
        {
            if (direction == 1)
            {
                if (this.transform.position.y < 7)
                {
                    this.transform.position = this.transform.position + moveVertical;
                }
                else { direction = 0; }
            }

            if (direction == 0)
            {
                if (this.transform.position.y > -7)
                {

                    this.transform.position = this.transform.position - moveVertical;
                }
                else { direction = 1; }
            }

        }    
     }
}
