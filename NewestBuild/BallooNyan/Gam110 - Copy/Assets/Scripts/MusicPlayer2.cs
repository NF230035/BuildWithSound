using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer2 : MonoBehaviour
{
    public GameObject player;
    static AudioSource Audio;
    Rigidbody2D rb;
    bool IsAudioPlaying;

    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
        rb = player.GetComponent<Rigidbody2D>();
        IsAudioPlaying = false;
        Audio.Stop();
        Audio.volume = 0.13f;
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.transform.position.y > 70 && IsAudioPlaying == false)
        {
            Audio.loop = true;
            Audio.Play();
            IsAudioPlaying = true;
            Audio.mute = false;
        }
        else if (IsAudioPlaying == false || rb.transform.position.y < 70)
        {
            Audio.mute = true;
        }

        

        if (rb.transform.position.y >= 280 && IsAudioPlaying == true)
        {
            Audio.loop = false;
            IsAudioPlaying = false;
            Audio.Stop();
         
        }
    }
}
