using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInfo : MonoBehaviour
{
    // Define variaveis pra checar se cada shrine já foi completa ou nao.
    public bool Shrine1Completed = false;
    public bool Shrine2Completed = false;
    public bool Shrine3Completed = false;
    public bool Shrine4Completed = false;
    public string LastShrineVisited = "None";

    public TrdControl player;

    [SerializeField]
    private RespawnPoint respawn1;
    [SerializeField]
    private RespawnPoint respawn2;
    [SerializeField]
    private RespawnPoint respawn3;
    [SerializeField]
    private RespawnPoint respawn4;
    [SerializeField]
    private RespawnPoint respawn5;

    public static GameInfo instance;

    //Checa para ver se so existe um gameInfo para nao duplicar e define o local de respawn quando entra na cena
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(this.gameObject);
        if (SceneManager.GetActiveScene().name == "MainGametest")
        {
            respawn1 = GameObject.Find("Respawn Shrine 1").GetComponent<RespawnPoint>();
            respawn2 = GameObject.Find("Respawn Shrine 2").GetComponent<RespawnPoint>();
            respawn3 = GameObject.Find("Respawn Shrine 3").GetComponent<RespawnPoint>();
            respawn4 = GameObject.Find("Respawn Shrine 4").GetComponent<RespawnPoint>();
            respawn5 = GameObject.Find("Respawn Shrine 5").GetComponent<RespawnPoint>();            
        }

    }
    
    void Start()
    {
        //SetPlayerPosition();
    }

    void Update()
    {
        
    }
    public void SetPlayerPosition()
    //Teleporta jogador pra perto da shrine certa quando ele sai da shrine
    {
        respawn1 = GameObject.Find("Respawn Shrine 1").GetComponent<RespawnPoint>();
        respawn2 = GameObject.Find("Respawn Shrine 2").GetComponent<RespawnPoint>();
        respawn3 = GameObject.Find("Respawn Shrine 3").GetComponent<RespawnPoint>();
        respawn4 = GameObject.Find("Respawn Shrine 4").GetComponent<RespawnPoint>();
        respawn5 = GameObject.Find("Respawn Shrine 5").GetComponent<RespawnPoint>();
        if (SceneManager.GetActiveScene().name == "MainGametest")
        {
            if (LastShrineVisited == "Shrine 1")
            {
                player.rdb.position = respawn1.transform.position;
                player.transform.rotation = respawn1.transform.rotation;
            }
            if (LastShrineVisited == "Shrine 2")
            {
                player.rdb.position = respawn2.transform.position;
                player.transform.rotation = respawn2.transform.rotation;
            }
            if (LastShrineVisited == "Shrine 3")
            {
                player.rdb.position = respawn3.transform.position;
                player.transform.rotation = respawn3.transform.rotation;
            }
            if (LastShrineVisited == "Shrine 4")
            {
                player.rdb.position = respawn4.transform.position;
                player.transform.rotation = respawn4.transform.rotation;
            }
            if (LastShrineVisited == "Boss Room")
            {
                player.rdb.position = respawn5.transform.position;
                player.transform.rotation = respawn5.transform.rotation;
            }
        }
    }
    public void IncreaseCount()
    {
        return;
    }
}
