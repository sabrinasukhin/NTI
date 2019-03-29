using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeViews : MonoBehaviour
{
    public Text viewText;
    public bool trainerView;
    public GameObject baby;
    public GameObject scissors;
    public GameObject bleach;
    public GameObject teddy;


    void Start()
    {
        trainerView = true;
        viewText.text = "Trainer View";
    }

    void Update()
    {
        if (!Input.GetKey(KeyCode.LeftShift))
        {
            trainerView = true;
            viewText.text = "Trainer View";
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            trainerView = false;
            viewText.text = "Agent View";
            /*if (currentBar < 0)
            {
                currentBar = 0;
                viewBar.value = CalcBar();
                cam.backgroundColor = alive;
                isAlive = true;

            }
            if (currentBar > 0)
            {
                currentBar -= decreaseTime * Time.deltaTime;
                viewBar.value = CalcBar();
                cam.backgroundColor = dead;
                isAlive = false;
            }*/
        }
    }
}

