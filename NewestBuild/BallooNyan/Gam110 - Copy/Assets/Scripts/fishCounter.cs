using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fishCounter : MonoBehaviour
{
    public Image img1;
    public Image img2;
    public Image img3;
    public Image img4;
    public Image img5;
    public treatCollector pControl;

    void Start()
    {
        img1.enabled = false;
        img2.enabled = false;
        img3.enabled = false;
        img4.enabled = false;
        img5.enabled = false;
    }


    void Update()
    {
        if (pControl.numTreats >= 1)
        {
            img1.enabled = true;

        }
        if (pControl.numTreats >= 2)
        {
            img2.enabled = true;

        }
        if (pControl.numTreats >= 3)
        {
            img3.enabled = true;

        }
        if (pControl.numTreats >= 4)
        {
            img4.enabled = true;

        }
        if (pControl.numTreats >= 5)
        {
            img5.enabled = true;
        }
        if (pControl.numTreats <= 0)
        {
            img1.enabled = false;
            img2.enabled = false;
            img3.enabled = false;
            img4.enabled = false;
            img5.enabled = false;

        }
    }
}