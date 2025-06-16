using UnityEngine;

public class LuzOpenDoor : MonoBehaviour
{
    public GameObject door;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        door.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Luz"))
        {
            door.SetActive(false);
        }
    }
}
