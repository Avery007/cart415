using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timevalue=600; // notice the number in unity interface, or it wont work
    public float timeRound=0;
    public UnityEngine.UI.Text text;
    public static bool start=false;
    public GameObject orb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            if (timevalue > 0)
                
            {
                Debug.Log(timevalue);
                //Debug.Log("okey");
                timeRound +=Time.deltaTime;

                timevalue = 600-Mathf.RoundToInt(timeRound);
                // Debug.Log(timevalue);
                text.text = "Time: " + timeRound;
            }
            else { timevalue = 0;
               
                orb.SetActive(false);
                text.text = "Game over, what you have achived?";


            }

        }
    }
}
