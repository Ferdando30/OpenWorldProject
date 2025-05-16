using UnityEngine;

public class Collectible : MonoBehaviour
{
    public static event System.Action OnCollected;
    public float CompleteShrine;
    

    [SerializeField]
    private ReturnPortal returnPortal;

    [SerializeField]
    private BossRoom bossRoom;

    [SerializeField]
    private GameInfo gameInfo;

    void OnTriggerEnter(Collider other)
    { 
        if (other.CompareTag("Player"))
        { 
            OnCollected?.Invoke();
            returnPortal.Activate();
            gameInfo.IncreaseCount();
            bossRoom.OpenBoss();
            gameObject.active = false;
        }
    }
}
