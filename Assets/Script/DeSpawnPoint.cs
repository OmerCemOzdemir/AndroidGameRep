using UnityEngine;

public class DeSpawnPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Road"))
        {
            Destroy(SpawnPoint.roads[0]);
            SpawnPoint.roads.RemoveAt(0);
            //Debug.Log("Inside Trigger Area");
        }

        Debug.Log("Inside Trigger Area");

    }

}
