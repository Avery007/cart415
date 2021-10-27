using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 randomY;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        randomY = new Vector3(-11, Random.Range(-4f, 4f), 0);
    }
    void FixedUpdate()
    {
        Vector3 change = this.transform.TransformVector(-0.2f, 0, 0);
        if (this.transform.position.x < 10)
        {
            this.transform.position = this.transform.position + change;
        }
        else { this.transform.position = randomY; }
    }
}
