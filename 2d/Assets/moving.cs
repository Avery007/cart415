using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moving : MonoBehaviour
{
    // Start is called before the first frame update
    public int direction = 1;
    public static int active = 1;// 1 means active, -1 inactive
    public UnityEngine.UI.Text text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        Vector3 moveVertical = this.transform.TransformVector(0, 2f, 0);
        if (active>0)
         {
            if (direction == 1)
            {
                if (this.transform.position.y < 5)
                {
                    this.transform.position = this.transform.position + moveVertical;
                }
                else { direction = 0; }
            }

            if (direction == 0)
            {
                if (this.transform.position.y > -5)
                {

                    this.transform.position = this.transform.position - moveVertical;
                }
                else { direction = 1; }
            }

        }    
     }
    public void NoMove ()
    {
        if (GetCrystal.count > 20)
        {
            GetCrystal.count = GetCrystal.count - 2;
            Orbfeature.resetCount = true;
            active = -active;
        }
        else { text.text = "Sorry, you need more points to do so, work harder!"; }
    }
}
