using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timevalue=120; // notice the number in unity interface, or it wont work
    public int timeRound;
    public UnityEngine.UI.Text message;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (timevalue > 0)
        {
            Debug.Log("okey");
            timevalue -= Time.deltaTime;
            
            timeRound = Mathf.RoundToInt(timevalue);
            Debug.Log(timevalue);
            message.text = "Your time left :" + timeRound;
        }
        else { timevalue = 0; }
    }
}
