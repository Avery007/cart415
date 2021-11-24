using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrownlMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 movement;
    public Vector3 randomLocate;
   // public Vector3 originIP;
    //public GameObject self;
    private WaitForSeconds waitTime;
    void Start()
    {
        //originIP = this.transform.position;
       
        waitTime = new WaitForSeconds(1);

    }

    // Update is called once per frame
    void Update()

    {

    }
    public void JobStart()
    {
        GetCrystal.count = GetCrystal.count - 5;
        GetCrown.CrownState = true;
       StartCoroutine(GoldMov());
    }
    IEnumerator GoldMov()
    {
        while (GetCrown.CrownState)
        {
            

            movement = new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 2f), 0);
            Vector3 change = this.transform.TransformVector(movement);
            if (this.transform.position.x > 10 || this.transform.position.x < -10 || this.transform.position.y > 4 || this.transform.position.y < -4)
            { randomLocate = new Vector3(Random.Range(-7f, 7f), Random.Range(-3f, 3f), 0); this.transform.position = randomLocate; }
            else { this.transform.position = this.transform.position + change; }
            this.transform.position = this.transform.position + change;
            yield return waitTime;
        }
    }
}
