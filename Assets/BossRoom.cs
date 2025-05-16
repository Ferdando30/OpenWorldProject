using UnityEngine;

public class BossRoom : MonoBehaviour
{
    public Collectible CollectibleScript;
    public GameObject portal;

    [SerializeField]
    private GameInfo gameInfo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OpenBoss();
    }
    public void OpenBoss()
    {
        if (gameInfo.ShrinesCompleted == 0)
        {
            portal.active = false;
        }

        if (gameInfo.ShrinesCompleted >= 1)
        {
            print("foi krl");
            portal.active = true;
        }
    }
}
