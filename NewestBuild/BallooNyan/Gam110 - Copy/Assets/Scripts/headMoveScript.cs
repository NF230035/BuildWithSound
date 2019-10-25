using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headMoveScript : MonoBehaviour
{
    public Animator animator2;
    public treatCollector pControl;
    public bool completeMeow = false;

    static AudioSource Audio;

    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (pControl.isMeowingTime == true)
        {
            Audio.Play();
            animator2.SetFloat("isMeowing", 1);
            pControl.isMeowingTime = false;
        }

        else
        {
            animator2.SetFloat("isMeowing", 0);
        }


    }
}

