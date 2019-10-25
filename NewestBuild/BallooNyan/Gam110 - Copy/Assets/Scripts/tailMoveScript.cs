using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tailMoveScript : MonoBehaviour
{
    public Animator animator;
    static AudioSource Audio;
    float move;
    bool IsAudioPlaying;

    void Start()
    {
        //Prepares the audio source for playing
        IsAudioPlaying = false;
        Audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal");

        if (move != 0)
        {
            animator.SetFloat("isMoving", 1);

            //Checks if the audio is playing already, if not, plays the audio.
            if (IsAudioPlaying == false)
            {
                Audio.loop = true;
                Audio.Play();
                IsAudioPlaying = true;
                Audio.volume = 0.15f;
            }

        }

        else
        {
            animator.SetFloat("isMoving", 0);

            //instead of stoping audio out right, it disables looping. If you stop the audio abruptly, weird clicking noise is heard.
            Audio.loop = false;
            IsAudioPlaying = false;

        }


    }
}
