using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer1 : MonoBehaviour
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
        Audio.volume = 0.13f;
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.transform.position.y < 70 && IsAudioPlaying == false)
        {
            Audio.Play();
            IsAudioPlaying = true;
        }
        if (rb.transform.position.y >= 70 && IsAudioPlaying == true)
        {
            Audio.Stop();
            IsAudioPlaying = false;
        }
    }
}
