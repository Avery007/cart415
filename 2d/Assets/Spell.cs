using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    // Start is called before the first frame update
    public static Vector3 randomY;
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
        Vector3 change = this.transform.TransformVector(-0.2f, 0, 0);
       
        
            if (this.transform.position.x > -12)
            {
                this.transform.position = this.transform.position + change;
            }
            else
            {
                randomY = new Vector3(12, Random.Range(-4f, 4f), 0);
                this.transform.position = randomY;
            }
        
       
            
    }
    public void KillSpell()
    {
        if (GetCrystal.count >= 100)
        {
           
            GetCrystal.count = GetCrystal.count - 100;
            Orbfeature.resetCount = true;
            text.text = "Well done, you wont be cursed anymore ";
            Destroy(theSpell);
        }
        else { text.text = "Sorry, you need more points to do stop the spell, work harder!"; } 
        
    }
}
