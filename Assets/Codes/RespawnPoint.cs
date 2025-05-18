using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnPoint : MonoBehaviour
{
    [SerializeField]
    private GameInfo gameInfo;
    void Awake()
    {
        gameInfo = GameObject.FindWithTag("Game Info").GetComponent<GameInfo>();
    }
    void Start()
    {
        Invoke("SetPlayerPosition", 0.1f);
    }
    void SetPlayerPosition()
    {
        gameInfo.SetPlayerPosition();
    }
}