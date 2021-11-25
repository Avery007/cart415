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
    public float speed = 20;
    public GameObject buttonVcontrol;
    public GameObject speedSlow;
    public GameObject speedUp;
  


    public UnityEngine.UI.Text text;
    public static bool resetCount = false; //disolay change reset

    void Start()
    {
        speedSlow.SetActive(false);
        speedUp.SetActive(false);
        //StartCoroutine(makeMove());

    }

    // Update is called once per frame
    void Update()
    {
        //timer += Time.deltaTime;
       
    }
    private void FixedUpdate()
    {
        if (this.transform.position.x > 10) // must in the update or it might disapear on screen by change
        {
            randomPos = new Vector3(-9, Random.Range(-3.5f, 3.5f), 0);
            this.transform.position = randomPos;
        }
    }
    public void makeMove()
    {
        //speed = -20 + speedChange;
    change = this.transform.TransformVector(speed, 0, 0);
        //moving.active = true;



        //yield return new WaitForSeconds(3);

        if (this.transform.position.x < 10)
            {
           // yield return new WaitForSeconds(3);
            this.transform.position = this.transform.position + change;
           

            }
         

        }
    
    public void speedControl()
    {
        if (GetCrystal.count >= 30) {
            buttonVcontrol.SetActive(false);
            speedSlow.SetActive(true);
            speedUp.SetActive(true);
            text.text = "You can change speed now!";
            GetCrystal.count -= 30;
            resetCount = true;
        }
        else { text.text = "Sorry, you need more points to change speed, work harder!"; }
    }
        
    
    public void speedslow() { 
    if (speed>5)
            {
                speedChange = speedChange -5;
                speed = 20 + speedChange;
            //GetCrystal.count = GetCrystal.count - 5;
               // resetCount = true;
                //speed = 20 + speedChange;
            text.text = "Your new speed: "+ speed;
        }
        
        else { text.text = "You cannot be slower"; }
    }
    public void speedup()
    {
        if (speed<30 )
        {
            speedChange = speedChange +5;
            speed = 20 + speedChange;
            //GetCrystal.count = GetCrystal.count - 5;
            //resetCount = true;
          
            text.text = "Your new speed: " + speed;
        }

        else { text.text = "Your cannot run faster"; }
    }
}


