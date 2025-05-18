using UnityEngine;

public class GameInfo : MonoBehaviour
{
    public int ShrinesCompleted = 0;
    public bool Shrine1Completed = false;
    public bool Shrine2Completed = false;
    public bool Shrine3Completed = false;
    public bool Shrine4Completed = false;
    public string LastShrineVisited = "None";

    public TrdControl player;

    [SerializeField]
    private RespawnPoint respawn1;

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
        //GameObject respawn1_obj = GameObject.Find("Respawn Shrine 1");
        //print("obj " + respawn1_obj);
        //respawn1 = respawn1_obj.GetComponent<RespawnPoint>();
        //print("respawn " + respawn1);

        respawn1 = GameObject.Find("Respawn Shrine 1").GetComponent<RespawnPoint>();
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
        print(": D");
        respawn1 = GameObject.Find("Respawn Shrine 1").GetComponent<RespawnPoint>();
        if (LastShrineVisited == "Shrine 1")
        {
            player.transform.position = respawn1.transform.position;
            player.transform.rotation = respawn1.transform.rotation;
        }
    }
    public void IncreaseCount()
    {
        ShrinesCompleted++;
    }
}
