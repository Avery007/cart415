using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Orbfeature: MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 randomPos;
    public bool clicking = false;
    public float timer=0;
    private Vector3 change ;
    public float speedChange = 0;
    public float speed = -20;
  

    public UnityEngine.UI.Text text;
    public static bool resetCount = false;

    void Start()
    {
        //StartCoroutine(makeMove());
        
    }

    // Update is called once per frame
    void Update()
    {
        //timer += Time.deltaTime;
       
    }
    public void makeMove()
    {
        speed = -20 + speedChange;
    change = this.transform.TransformVector(speed, 0, 0);
        //moving.active = true;



        //yield return new WaitForSeconds(3);

        if (this.transform.position.x > -11)
            {
           // yield return new WaitForSeconds(3);
            this.transform.position = this.transform.position + change;
           

            }
            else
        {
            randomPos = new Vector3(10, Random.Range(-3.5f, 3.5f), 0); 
            this.transform.position = randomPos; 
            //moving.active = false;
        
        }

        }
    public void timeCount()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);
        if (timer>10)
        {
            timer = 0;
            //speed = -0.5f;
        }

    }
    public void speedup()
    {
        if (GetCrystal.count >= 10) {

            // Vector3 speedAdd = new Vector3(-5, 0, 0);
            if (speedChange < 14)
            {
                speedChange = speedChange + 5;

                GetCrystal.count = GetCrystal.count - 5;
                resetCount = true;
            }
        }
    }
    }


