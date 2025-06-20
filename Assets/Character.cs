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
    Animator animator;

    float time = 0f;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
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
        float normalizedSpeed = Mathf.InverseLerp(0f, agent.speed, agent.velocity.magnitude);
        animator.SetFloat("Speed", normalizedSpeed);
        //if (Input.GetKey(KeyCode.Alpha1)) {
        //    animator.SetFloat("Speed", 0f); // idle
        //} else if (Input.GetKey(KeyCode.Alpha2)) {
        //    animator.SetFloat("Speed", 0.5f); // walk
        //} else if (Input.GetKey(KeyCode.Alpha3)) {
        //    animator.SetFloat("Speed", 1f); // run
        //}
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
