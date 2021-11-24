using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startgame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spell;
    public GameObject orb;
    public GameObject self;
    public GameObject button;
    void Start()
    {
        spell.SetActive(false);
        orb.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Gamestart()
    {
        spell.SetActive(true);
        orb.SetActive(true);
        self.SetActive(false);
        button.SetActive(false);
        Timer.start= true;

    }

    
}
