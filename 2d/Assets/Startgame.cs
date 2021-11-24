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
    public AudioSource source;
    void Start()
    {
        spell.SetActive(false);
        orb.SetActive(false);
        source = GetComponent<AudioSource>();
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
        source.Play();
    }

    
}
