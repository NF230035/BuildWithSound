using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonPopping : MonoBehaviour
{
    public PlayerController pControl;
    public GameObject player;
    public float popBlowback;
    private Rigidbody2D pRb;

    static AudioSource Audio;
    public AudioClip PopSound;

    private void Start()
    {
        //PopSound = Resources.Load<AudioClip>("BalloonPopSound");
        pRb = player.GetComponent<Rigidbody2D>();
        Audio = player.GetComponent<AudioSource>();
        Audio.volume = 0.25f;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Obstacle"))
        {
            Audio.PlayOneShot(PopSound);

            pControl.BalloonsLeft -= 1;
            pRb.velocity = new Vector2(0, 5) * popBlowback;
            Destroy(this.gameObject);
        }
    }
}
