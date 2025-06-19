using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitLocation : MonoBehaviour
{
    public GameObject wall;
    public int hp = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerProjectile"))
        {
            Hit();
        }
    }
    private void Hit()
    {
        hp -= 1;
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
