using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getOrb : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject orb;
    public UnityEngine.UI.Text text;
    public static int count = 0;
    public Vector3 randomPo;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collidde with something");
        if (collision.collider.gameObject == orb)
        {
            count = count + 1;
            this.transform.position = randomPo;
            Debug.Log("collided with player");
            text.text = "Your orb" + count;

        }
        


    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        randomPo = new Vector3(11, Random.Range(-4f, 4f), 0);
    }
    private void FixedUpdate()
    {
        if (arrow.reset)
        {
            text.text = "Your orb" + count;
        }
        

    }
}
