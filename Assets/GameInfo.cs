using UnityEngine;

public class GameInfo : MonoBehaviour
{
    public int ShrinesCompleted = 0;
    public bool Shrine1Completed = false;
    public bool Shrine2Completed = false;
    public bool Shrine3Completed = false;
    public bool Shrine4Completed = false;
    public string LastShrineVisited = "None";
    
    [SerializeField]
    private TrdControl player;

    [SerializeField]
    private RespawnPoint respawn1;

    void Awake()
    {
        player = GameObject.FindWithTag("Player").GetComponent<TrdControl>();
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Game Info");

        if (objs.Length > 1)
        { 
            Destroy(this.gameObject);
        }   
        
        DontDestroyOnLoad(this.gameObject);
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void SetPlayerPosition()
    {
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
