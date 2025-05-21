using UnityEngine;

public class Shrine2Collectible : MonoBehaviour
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
    
    void Start()
    {
        if (gameInfo.Shrine2Completed == true)
        {
            returnPortal.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    { 
        if (other.CompareTag("Player"))
        { 
            OnCollected?.Invoke();
            returnPortal.Activate();
            gameInfo.Shrine2Completed = true;
            //bossRoom.OpenBoss();
            gameObject.active = false;
        }
    }
}
