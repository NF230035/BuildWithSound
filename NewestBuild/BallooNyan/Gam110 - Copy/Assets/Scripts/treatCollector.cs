using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treatCollector : MonoBehaviour
{
    public int numTreats = 0;
    public bool isMeowingTime = false;
    public headMoveScript pControl;
    public PlayerController pControl3;
    //public Transform Ballons1, Ballons2, Ballons3, Ballons4, Ballons5;
    private int balloonType;
    private int randomBalloon;
    public GameObject[] balloons;
    private float ranRangeX;
    private float ranRangeY;

    void Update()
    {
        while (numTreats >= 5)
        {
            fiveFish();
        }
    }
    public void fiveFish()
    {
        randomBalloon = Random.Range(1, 5);
        ranRangeX = Random.Range(-0.4f, 0.4f);
        ranRangeY = Random.Range(-0.25f, 1.1f);

        var addBalloon = Instantiate(balloons[randomBalloon], new Vector3(this.transform.position.x + ranRangeX, this.transform.position.y + ranRangeY, this.transform.position.z), Quaternion.identity);
        addBalloon.transform.parent = gameObject.transform;
        pControl3.BalloonsLeft = pControl3.BalloonsLeft + 1;
        numTreats = 0;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Treat"))
        {
            Destroy(col.gameObject);
            numTreats = numTreats + 1;
            isMeowingTime = true;

        }
    }
}
