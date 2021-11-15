using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arrow : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 randomPos;
    public bool clicking = false;
    public float timer=0;
    Vector3 change ;
    public float speed = -0.5f;
    public UnityEngine.UI.Text text;
    public static bool reset = false;

    void Start()
    {
        //StartCoroutine(makeMove());
        
    }

    // Update is called once per frame
    void Update()
    {
        //timer += Time.deltaTime;
        randomPos = new Vector3(11, Random.Range(-4f, 4f), 0);
    }
    public void makeMove()
    {
    change = this.transform.TransformVector(speed, 0, 0);
        moving.active = true;


        //yield return new WaitForSeconds(3);

        if (this.transform.position.x > -11)
            {
           // yield return new WaitForSeconds(3);
            this.transform.position = this.transform.position + change;
           

            }
            else { this.transform.position = randomPos; 
                   moving.active = false;
        
        }

        }
    public void timeCount()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);
        if (timer>10)
        {
            timer = 0;
            speed = -0.5f;
        }

    }
    public void speedup(int movespeed)
    {
        if (getOrb.count - 5 > 0) { 
            speed = speed+movespeed;
        
            getOrb.count = getOrb.count - 5;
            reset = true;
            Debug.Log(getOrb.count);
        }
    }
    }


