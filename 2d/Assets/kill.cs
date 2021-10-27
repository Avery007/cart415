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
        Debug.Log("collidde with something");
        if (collision.collider.gameObject == player)
        {                
    
            Debug.Log("collided with player");
            text.text = "Sorry you die on the way!";

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
