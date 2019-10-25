using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyMoveScript : MonoBehaviour
{
    public GameObject player;
    public Animator animator1;
    public GameObject[] objs;

    void Start()
    {
        objs = GameObject.FindGameObjectsWithTag("Treat");
    }

    void Update()
    {
        foreach (var obj in objs)
        {
            if(Vector3.Distance(player.transform.position, obj.transform.position) < 5)
            {
                animator1.SetFloat("isAttracted", 1);
            }
            if (Vector3.Distance(player.transform.position, obj.transform.position) >= 6)
            {
                animator1.SetFloat("isAttracted", 0);
            }

        }
    }
}
