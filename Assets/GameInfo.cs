using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInfo : MonoBehaviour
{
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

    public static GameInfo instance;

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

        respawn1 = GameObject.Find("Respawn Shrine 1").GetComponent<RespawnPoint>();
        respawn2 = GameObject.Find("Respawn Shrine 2").GetComponent<RespawnPoint>();
        respawn3 = GameObject.Find("Respawn Shrine 3").GetComponent<RespawnPoint>();
        respawn4 = GameObject.Find("Respawn Shrine 4").GetComponent<RespawnPoint>();
    }
    
    void Start()
    {
        //SetPlayerPosition();
    }

    void Update()
    {
        
    }
    public void SetPlayerPosition()
    {
        respawn1 = GameObject.Find("Respawn Shrine 1").GetComponent<RespawnPoint>();
        respawn2 = GameObject.Find("Respawn Shrine 2").GetComponent<RespawnPoint>();
        respawn3 = GameObject.Find("Respawn Shrine 3").GetComponent<RespawnPoint>();
        respawn4 = GameObject.Find("Respawn Shrine 4").GetComponent<RespawnPoint>();
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
        }
    }
    public void IncreaseCount()
    {
        return;
    }
}
