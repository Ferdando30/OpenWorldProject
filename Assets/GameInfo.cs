using UnityEngine;

public class GameInfo : MonoBehaviour
{
    public int ShrinesCompleted = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncreaseCount()
    {
        ShrinesCompleted++;
    }
}
