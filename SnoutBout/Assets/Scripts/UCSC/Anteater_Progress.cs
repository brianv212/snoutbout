using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Anteater_Progress : MonoBehaviour
{
    private Image prog;

    private float anteaterProg;
    private float finishLine = 79f;

    private bool finished = false;

    GameObject sammy;


    private void Start()
    {
        prog = GetComponent<Image>();
        sammy = GameObject.Find("Anteater");
    }

    private void Update()
    {
        if (sammy)
        {
            anteaterProg = sammy.transform.position.x;
            if (anteaterProg > finishLine)
            {
                finished = true;
            }
            else
            {
                doFill();
            }
        }
    }

    private void doFill()
    {
        if (finished == false)
        {
            anteaterProg = sammy.transform.position.x;
            prog.fillAmount = anteaterProg / finishLine;
        }

    }
}