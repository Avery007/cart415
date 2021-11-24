using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    //public GameObject text;
    //public Transform target;
    public UnityEngine.UI.Text text;

    private void OnCollisionEnter2D(Collision2D collision)
    {
           //Debug.Log("collidde with something");
        if (collision.collider.gameObject == player)
        {
            this.transform.position = Spell.randomY;
            GetCrystal.count = GetCrystal.count - 5;
            Orbfeature.resetCount = true;
            text.text = "oops! You got cursed and you lose 5 points!";

        }



    }
            void Start()
            {

            }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
