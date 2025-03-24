using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private float obstacleSpeedMultiplier;
    [SerializeField] private Transform[] obstaclePositions;
    [HideInInspector] public static List<GameObject> obstacles = new List<GameObject>();


    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 1.0f, 3f);
    }


    private void SpawnObstacle()
    {
        int randObstaclePosition = Random.Range(-1, 3);
        Debug.Log("Random number: " + randObstaclePosition);
        obstacles.Add(Instantiate(obstaclePrefab, obstaclePositions[randObstaclePosition].position, Quaternion.identity));

    }

    private void Update()
    {
        foreach (var obstacle in obstacles)
        {
            obstacle.transform.position += new Vector3(1f * obstacleSpeedMultiplier, 0, 0);
        }
    }

}
