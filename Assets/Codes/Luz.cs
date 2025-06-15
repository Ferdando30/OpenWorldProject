using UnityEngine;

public class Luz : MonoBehaviour
{
    public GameObject Lights;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Lights.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Luz"))
        {
            Lights.SetActive(true);
        }
    }
}
