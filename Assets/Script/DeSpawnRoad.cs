using UnityEngine;

public class DeSpawnRoad : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Road"))
        {
            Destroy(SpawnPoint.Roads[0]);
            SpawnPoint.Roads.RemoveAt(0);
            //Debug.Log("Inside Trigger Area");
        }

        Debug.Log("Inside Trigger Area");

    }

}
