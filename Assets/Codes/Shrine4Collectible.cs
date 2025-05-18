using UnityEngine;

public class Shrine4Collectible : MonoBehaviour
{
    public static event System.Action OnCollected;
    public float CompleteShrine;
    

    [SerializeField]
    private ReturnPortal returnPortal;

    [SerializeField]
    private BossRoom bossRoom;

    [SerializeField]
    private GameInfo gameInfo;

    void Awake()
    {
        gameInfo = GameObject.FindWithTag("Game Info").GetComponent<GameInfo>();
    }

    void OnTriggerEnter(Collider other)
    { 
        if (other.CompareTag("Player"))
        { 
            OnCollected?.Invoke();
            returnPortal.Activate();
            gameInfo.Shrine4Completed = true;
            //bossRoom.OpenBoss();
            gameObject.active = false;
        }
    }
}
