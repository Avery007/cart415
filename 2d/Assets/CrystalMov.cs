using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalMov: MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 movement;
    public Vector3 randomLocate;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        
    }

    void FixedUpdate()
    {
        movement = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
        Vector3 change = this.transform.TransformVector(movement);
        if (this.transform.position.x >11 || this.transform.position.x < -11 ||this.transform.position.y >6 ||this.transform.position.y <-6)
        { randomLocate = new Vector3(Random.Range(-7f, 7f), Random.Range(-3f, 3f), 0); this.transform.position = randomLocate; }
        else {  this.transform.position = this.transform.position + change; }
        this.transform.position = this.transform.position + change;
    }
}
