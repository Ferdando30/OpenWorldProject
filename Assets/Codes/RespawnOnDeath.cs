using UnityEngine;

public class RespawnOnDeath : MonoBehaviour
{
    [SerializeField]
    private respawnPoint respawnPoint;

    void OnTriggerEnter(Collider other)
    { 
        if (other.CompareTag("Player"))
        { 
            other.transform.position = respawnPoint.transform.position;
            other.transform.rotation = respawnPoint.transform.rotation;
        }
    }
}
