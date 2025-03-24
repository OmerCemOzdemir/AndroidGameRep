using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject RoadPrefab;
    [SerializeField] private float roadSpeedMultiplier;
    [HideInInspector] public static List<GameObject> Roads = new List<GameObject>();



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRoad", 2.0f, 1.5f);
    }


    private void SpawnRoad()
    {
        Roads.Add(Instantiate(RoadPrefab, transform.position, Quaternion.identity));
    }

    private void Update()
    {
        foreach (var road in Roads)
        {
            road.transform.position += new Vector3(1 * roadSpeedMultiplier, 0, 0);
        }
    }


}
