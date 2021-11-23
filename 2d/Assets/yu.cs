using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yu : MonoBehaviour
{
    public GameObject vise; // have to define obj to use setactive
    public float countTime;
    private WaitForSeconds waitTime;
    public static int setting = 1;
    public UnityEngine.UI.Text text;
    // Start is called before the first frame update
    void Start()
    {
        vise.SetActive(false);
        waitTime = new WaitForSeconds(20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Mine()
    {
        if (setting > 0)
        {
            vise.SetActive(true);
        }
        else { vise.SetActive(false); }
    }

    public void Jobtime()
        
    {
        if (GetCrystal.count > 10)
        {
            GetCrystal.count = GetCrystal.count - 100;
            StartCoroutine(Timer());
        }
        else { text.text = "Sorry you dont have enough points to mine,work harder!"; }
        
        
    }
    IEnumerator Timer()
    {
        while (true)
        {
           // if (setting < 0)
            //{
                yield return waitTime;

                // vise.SetActive(true);
                setting = -setting;
            Mine();
                Debug.Log(setting);
                
        }
    }
}
