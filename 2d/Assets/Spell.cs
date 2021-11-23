using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    // Start is called before the first frame update
    public static Vector3 randomY;
    public bool status = true;
    public GameObject theSpell;
    public UnityEngine.UI.Text text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        Vector3 change = this.transform.TransformVector(0.2f, 0, 0);
        if (status)
        {
            if (this.transform.position.x < 12)
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
           theSpell.SetActive(false); }
    }
    public void KillSpell()
    {
        if (GetCrystal.count >= 20)
        {
            status = false;
            GetCrystal.count = GetCrystal.count - 500;
            Orbfeature.resetCount = true;
        }
        else { text.text = "Sorry, you need more points to do stop the spell, work harder!"; } 
        
    }
}
