using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sammy_Progress : MonoBehaviour
{
    private Image prog;

    private float sammyProg;
    private float finishLine = 79f;

    private bool finished = false;

    GameObject sammy;


    private void Start()
    {
        prog = GetComponent<Image>();
        sammy = GameObject.Find("Sammy_Slug");
    }

    private void Update()
    {
        if (sammy)
        {
            sammyProg = sammy.transform.position.x;
            if (sammyProg > finishLine){
                finished = true;
            }
            else {
                doFill();
            }
        }
    }

    private void doFill() {
        if (finished == false) { 
            sammyProg = sammy.transform.position.x;
            prog.fillAmount = sammyProg / finishLine;        
        }

    }
}