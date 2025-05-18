using UnityEngine;

public class BossRoom : MonoBehaviour
{
    public Collectible CollectibleScript;
    public GameObject portal;

    [SerializeField]
    private GameInfo gameInfo;
    
    void Awake()
    {
        gameInfo = GameObject.FindWithTag("Game Info").GetComponent<GameInfo>();
    }

    void Start()
    {
        OpenBoss();
    }

    
    void Update()
    {
        
    }
    public void OpenBoss()
    {
        if (gameInfo.Shrine1Completed == false || gameInfo.Shrine2Completed == false || gameInfo.Shrine3Completed == false || gameInfo.Shrine4Completed == false)
        {
            portal.active = false;
        }

        if (gameInfo.Shrine1Completed == true && gameInfo.Shrine2Completed == true && gameInfo.Shrine3Completed == true && gameInfo.Shrine4Completed == true)
        {
            print("foi krl");
            portal.active = true;
        }
    }
}
