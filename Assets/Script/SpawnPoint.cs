using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject roadPrefab;
    [SerializeField] private float roadSpeedMultiplier;
    [HideInInspector] public static List<GameObject> roads = new List<GameObject>();



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(SpawnRoad), 1.0f, 1f);
    }


    private void SpawnRoad()
    {
        roads.Add(Instantiate(roadPrefab, transform.position, Quaternion.identity));
    }

    private void Update()
    {
        foreach (var road in roads)
        {
            road.transform.position += new Vector3(1f * roadSpeedMultiplier, 0, 0);
        }
    }


}
