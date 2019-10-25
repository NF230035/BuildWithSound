using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGeneration : MonoBehaviour
{
    public GameObject[] obstacles;
    public int numberOfObstacles;
    public float levelWidth;
    public float minY;
    public float maxY;
    private int index;


    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        
        for (int i = 0; i < numberOfObstacles; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            index = Random.Range(0, obstacles.Length);
            Instantiate(obstacles[index], spawnPosition, Quaternion.identity);
        }
    }

}
