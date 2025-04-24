using UnityEngine;

public class Collectible : MonoBehaviour
{
    public static event System.Action OnCollected;
    //void Update()
    //{
        
    //}

    void OnTriggerEnter(Collider other)
    { 
        if (other.CompareTag("Player"))
        { 
            OnCollected?.Invoke();
            Destroy(gameObject);
        }
    }
}
