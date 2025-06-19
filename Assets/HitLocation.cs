using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitLocation : MonoBehaviour
{
    public Path path;
    public Character character;
    public GameObject wall;
    public int hp = 3;

    float elapsedTime = 0f;
    float bossTimer = 0f;
    bool bossHit = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= 20f)
        {
            wall.active = false;
        }
        if (bossHit == true)
        {
            bossTimer += Time.deltaTime;
            if (bossTimer < 9)
            {
                bossHit = true;
            }
            else
            {
                bossHit = false;
            }
        }
        else
        {
            character.waitTimeOnWaypoint = 3.5f;
            bossTimer = 0f;
            bossHit = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerProjectile"))
        {
            if (wall.active == false)
            {
                Hit();
            }
        }
    }
    private void Hit()
    {
        wall.active = true;
        elapsedTime = 0f;
        hp -= 1;
        path.direction *= -1;
        bossHit = true;
        character.waitTimeOnWaypoint = 12f;
        if (hp < 0)
        {
            hp = 0;
        }
        if (hp == 0)
        {
            Die();
        }
    }
    private void Die()
    {
        StartCoroutine(MyLoadScene());
    }
    IEnumerator MyLoadScene()
    {
        Camera.main.SendMessage("FadeOut");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Creditos");
    }
}
