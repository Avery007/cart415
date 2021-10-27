using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 randomPos;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        randomPos = new Vector3(11, Random.Range(-4f, 4f), 0);
    }
    void FixedUpdate()
    {
        Vector3 change = this.transform.TransformVector(-0.2f, 0, 0);
        if (this.transform.position.x > -11)
        {
            this.transform.position = this.transform.position + change;
        }
        else { this.transform.position = randomPos; }
    }
}
