using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnPortal : MonoBehaviour
{
    public string Shrine;

    [SerializeField]
    private GameInfo gameInfo;
    void Awake()
    {
        gameInfo = GameObject.FindWithTag("Game Info").GetComponent<GameInfo>();
    }
    
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(MyLoadScene());
        }
    }
    IEnumerator MyLoadScene()
    {
        Camera.main.SendMessage("FadeOut");
        gameInfo.LastShrineVisited = Shrine;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("MainGametest");
    }

    public void Activate()
    { 
        if(!gameObject.activeSelf)
        { 
            gameObject.SetActive(true);
        }
    }
}
