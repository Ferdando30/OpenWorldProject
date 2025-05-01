using UnityEngine;

public class RespawnOnDeath : MonoBehaviour
{
    [SerializeField]
    private RespawnPoint respawnPoint;
    
    [SerializeField]
    private TrdControl player;

    void OnTriggerEnter(Collider other)
    { 
        if (other.CompareTag("Player"))
        { 
            player.transform.position = respawnPoint.transform.position;
            player.transform.rotation = respawnPoint.transform.rotation;
        }
    }
}
