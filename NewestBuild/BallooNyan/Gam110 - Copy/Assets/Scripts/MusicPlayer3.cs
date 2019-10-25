using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer3 : MonoBehaviour
{
    public GameObject player;
    static AudioSource Audio;
    Rigidbody2D rb;
    private bool IsAudioPlaying;

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
        if (rb.transform.position.y > 280 && IsAudioPlaying == false)
        {
            Audio.mute = false;
            Audio.loop = true;
            Audio.Play();
            IsAudioPlaying = true;
        }
        if (IsAudioPlaying == false || rb.transform.position.y < 280)
        {
            Audio.Stop();
            Audio.loop = false;
            Audio.mute = true;
        }
    }
}
