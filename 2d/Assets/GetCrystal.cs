using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCrystal: MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject crystal;
    public UnityEngine.UI.Text text;
    public static int count = 0;
    public Vector3 randomPo;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collidde with something");
        if (collision.collider.gameObject == crystal)
        {
            count = count + 1;
            randomPo = new Vector3(10, Random.Range(-4f, 4f), 0);
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
        
    }
    private void FixedUpdate()
    {
        if (Orbfeature.resetCount)
        {
            text.text = "Your orb" + count;
        }
        

    }
}
