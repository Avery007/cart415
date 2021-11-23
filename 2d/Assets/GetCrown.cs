using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCrown : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject orb;
    public UnityEngine.UI.Text text;
    public static int count = 0;
    public Vector3 randomPo;
    public Vector3 originIP=new Vector3(-2, -5, 0);
    public static bool CrownState;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collidde with something");
        if (collision.collider.gameObject == orb)
        {
            CrownState = false;
            //count = count + 1;
            
            this.transform.position = originIP;//doesent work?
            GetCrystal.count += 20;
            Orbfeature.resetCount = true;
            Debug.Log("collided with player");
            //text.text = "Your orb" + count;


        }



    }
    void Start()
    {
        //originIP = this.transform.position;

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        //if (Orbfeature.resetCount)
        {
           // text.text = "Your orb" + count;
        }


    }
}


    // Update is called once per frame
 

