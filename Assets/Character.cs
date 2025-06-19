using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    public string Shrine;

    [SerializeField]
    private GameInfo gameInfo;

    [SerializeField]
    public float waitTimeOnWaypoint = 1f;

    [SerializeField]
    Path path;

    NavMeshAgent agent;
    //Animator animator;

    float time = 0f;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        gameInfo = GameObject.FindWithTag("Game Info").GetComponent<GameInfo>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent.destination = path.GetCurrentWaypoint();
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance <= 0.1f)
        {
            time += Time.deltaTime;
            if (time >= waitTimeOnWaypoint)
            {
                time = 0f;
                agent.destination = path.GetNextWaypoint();
            }
        }
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
}
