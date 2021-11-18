using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow1 : MonoBehaviour
{
    // Start is called before the first frame update
    public static Vector3 randomY;
    public bool status = true;
    public GameObject thisarrow;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        Vector3 change = this.transform.TransformVector(-0.2f, 0, 0);
        if (status)
        {
            if (this.transform.position.x < 16)
            {
                this.transform.position = this.transform.position + change;
            }
            else
            {
                randomY = new Vector3(-12, Random.Range(-4f, 4f), 0);
                this.transform.position = randomY;
            }
        }
        else { //Destroy(thisarrow);
            thisarrow.SetActive(false); }
    }
    public void KillArrow(bool state)
    {
        if (GetCrystal.count >= 0)
        {
            status = state;
        }
    }
}
