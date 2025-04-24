using UnityEngine;

public class Collectible : MonoBehaviour
{
    public static event System.Action OnCollected;
    //void Update()
    //{
        
    //}

    [SerializeField]
    private ReturnPortal returnPortal;

    void OnTriggerEnter(Collider other)
    { 
        if (other.CompareTag("Player"))
        { 
            OnCollected?.Invoke();
            returnPortal.Activate();
            Destroy(gameObject);
        }
    }
}
