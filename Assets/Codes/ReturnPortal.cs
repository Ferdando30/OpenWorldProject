using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnPortal : MonoBehaviour
{
    public string Shrine;

    [SerializeField]
    private GameInfo gameInfo;
    //Define gameInfo quando a cena carrega.
    void Awake()
    {
        gameInfo = GameObject.FindWithTag("Game Info").GetComponent<GameInfo>();
    }
    
    void Start()
    {
        
    }

    //Checa se o player entrou no portal.
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(MyLoadScene());
        }
    }
    //Define a ultima shrine que o jogador entrou no gameInfo como si mesma e carrega a main scene de novo.
    IEnumerator MyLoadScene()
    {
        Camera.main.SendMessage("FadeOut");
        gameInfo.LastShrineVisited = Shrine;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("MainGametest");
    }

    //Faz o gameObject ficar ativo depois de coletar o coletavel associado.
    public void Activate()
    {
        if (!gameObject.activeSelf)
        {
            gameObject.SetActive(true);
        }
    }
}
