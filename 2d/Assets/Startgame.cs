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
    public GameObject buttonMove;
    public GameObject text1;
    public GameObject text2;
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;

    public GameObject buttonSpeed;
    public GameObject buttonCrown;
    public GameObject buttonCurse;
    public GameObject buttonStop;
    public GameObject buttonMine;

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
        buttonMove.SetActive(true);
        text1.SetActive(true);
        text2.SetActive(true);
        Timer.start= true;
        buttonCrown.SetActive(true);
        buttonSpeed.SetActive(true);
        buttonMine.SetActive(true);
        buttonCurse.SetActive(true);
        buttonStop.SetActive(true);
        c1.SetActive(true);
        c2.SetActive(true);
        c3.SetActive(true);
        source.Play();
    }

    
}
