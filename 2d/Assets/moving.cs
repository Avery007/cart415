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
    public GameObject jump;
    public GameObject stay;
    public GameObject stateButton;
    //  public UnityEngine.UI.Text textButton;
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
                if (this.transform.position.y < 4)
                {
                    this.transform.position = this.transform.position + moveVertical;
                }
                else { direction = 0; }
            }

            if (direction == 0)
            {
                if (this.transform.position.y > -4)
                {

                    this.transform.position = this.transform.position - moveVertical;
                }
                else { direction = 1; }
            }

        }    
     }

    public void StateChange()
    {
        if (GetCrystal.count > 15)
        {
            stateButton.SetActive(false);
              GetCrystal.count = GetCrystal.count - 15;
            Orbfeature.resetCount = true;

            jump.SetActive(true);
            stay.SetActive(true);
        }
        else { text.text = "Sorry, you need more points to do so, work harder!"; }
    }
    public void NoMove()
    {    
            active = -1;     
    }
    public void Jump()
    {
        active = 1;
    }
}
