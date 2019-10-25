using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //movement variables
    public float MaxSpeed = 2;
    public int BalloonsLeft = 5;
    public GameObject gameOverui;
    public Transform Parachute;
    public bool firstRun;
    private float move;
    private bool FacingRight;
    private Rigidbody2D myrb;
    static AudioSource Audio;
    bool IsAudioPlaying;
    public Animator animator1;
    public Animator animator2;

    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
        myrb = GetComponent<Rigidbody2D>();
        FacingRight = false;
        firstRun = true;
        IsAudioPlaying = false;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Moving around
        move = Input.GetAxis("Horizontal");
        myrb.velocity = new Vector2(move * MaxSpeed, BalloonsLeft);

        //Flipping the cat
        if (move > 0 && !FacingRight)
        {
            flip();
            transform.localPosition += new Vector3(-1.35f, 0f, 0f);

        }
        //Flipping the cat
        else if (move < 0 && FacingRight)
        {
            flip();
            transform.localPosition += new Vector3(1.35f, 0f, 0f);

        }

        if (BalloonsLeft == 0)
        {
            myrb.gravityScale = 100;
            StartCoroutine(DeathDelay());
            //Disabling colliders
            this.gameObject.GetComponent<Collider2D>().enabled = false;
            animator1.SetFloat("isDead", 1);
            animator2.SetFloat("isDead", 1);

            //Checks if the audio is playing already, if not, plays the audio.
            if (IsAudioPlaying == false)
            {
                Audio.Play();
                IsAudioPlaying = true;
            }

            //Spawning the parachute
            if (firstRun == true)
            {
                if (FacingRight == true)
                {
                    var enablePara = Instantiate(Parachute, new Vector3(transform.position.x + 0.75f, transform.position.y - 0.5f, transform.position.z), Quaternion.identity);
                    enablePara.transform.parent = gameObject.transform;
                    firstRun = false;
                }
                if (FacingRight == false)
                {
                    var enablePara = Instantiate(Parachute, new Vector3(transform.position.x - 0.75f, transform.position.y - 0.5f, transform.position.z), Quaternion.identity);
                    enablePara.transform.parent = gameObject.transform;
                    firstRun = false;
                }
            }
        }
    }

    void flip()
    {
        FacingRight = !FacingRight;
        Vector3 TheScale = transform.localScale;
        TheScale.x *= -1;
        transform.localScale = TheScale;
    }

    IEnumerator DeathDelay()
    {
        yield return new WaitForSeconds(3);
        Time.timeScale = 0;
        gameOverui.SetActive(true);

    }

}
