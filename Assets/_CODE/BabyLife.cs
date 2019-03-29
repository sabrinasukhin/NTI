using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BabyLife : MonoBehaviour
{
    public Text lifeText;
    private int Life;

    void Start()
    {
        Life = 100;
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Hazard")
        {
            Life -= 50;
        }

        if (col.gameObject.tag == "Toy")
        {
            Life += 50;
        }
    }

    void Update()
    {
        lifeText.text = "Health: " + Life;
    }
}
