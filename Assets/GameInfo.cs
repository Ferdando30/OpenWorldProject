using UnityEngine;

public class GameInfo : MonoBehaviour
{
    public int ShrinesCompleted = 0;
    public bool Shrine1Completed = false;
    public bool Shrine2Completed = false;
    public bool Shrine3Completed = false;
    public bool Shrine4Completed = false;
    
    void Awake()
    {
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
    public void IncreaseCount()
    {
        ShrinesCompleted++;
    }
}
