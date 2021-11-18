using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystalmove : MonoBehaviour
{
    // Start is called before the first frame update
    public static Vector3 randomX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
       // Vector3 mov = this.transform.TransformVector(0, -1f, 0);
       if (this.transform.position.y <-3) //notice the position, a bit werid
        {
          randomX = new Vector3(Random.Range(-8f, 8f),3f, 0);
              this.transform.position = randomX; }
    }
}
