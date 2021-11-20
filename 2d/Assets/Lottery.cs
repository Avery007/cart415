using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lottery : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject vise;
    public int gains;
    public UnityEngine.UI.Text text;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collidde with something");
        if (collision.collider.gameObject == player)
        {
            if (Yu.setting > 0)
            {
                vise.SetActive(false);
                gains = Random.Range(1, 5);
                if (gains > 4)
                {
                    gains = 50;
                }
                else { gains = gains * 5; }

                GetCrystal.count += gains;
                Orbfeature.resetCount = true;

                Debug.Log("collided with player");
                text.text = "Congraduations! You have got: " + gains;

            }

        }


    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        
    }
}
