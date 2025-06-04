using UnityEngine;

public class BossRoom : MonoBehaviour
{
    //definição das variaveis que puxam o script dos coletaveis e os objetos do porta e gameInfo

    public Collectible CollectibleScript;
    public GameObject portal;

    [SerializeField]
    private GameInfo gameInfo;
    
    void Awake()
    {
        //puxar o script do gameInfo
        
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
       //definindo que quando todas as shrines forem finalizadas o portal para a boss room vai spawnar
        
        if (gameInfo.Shrine1Completed == false || gameInfo.Shrine2Completed == false || gameInfo.Shrine3Completed == false || gameInfo.Shrine4Completed == false)
        {
            portal.active = false;
        }

        if (gameInfo.Shrine1Completed == true && gameInfo.Shrine2Completed == true && gameInfo.Shrine3Completed == true && gameInfo.Shrine4Completed == true)
        {
            
            portal.active = true;
        }
    }
}
