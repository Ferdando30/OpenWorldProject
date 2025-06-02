using UnityEngine;

public class Shirne02_DoorSys : MonoBehaviour
{
    public GameObject door;

    [SerializeField]
    private IADamage IADamageScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        IADamageScript = GameObject.FindWithTag("Enemy").GetComponent<IADamage>();
    }
    void Start()
    {
        door.SetActive(true);
        IADamageScript.EnemyOnArea = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(IADamageScript.EnemyOnArea == 0)
        {
            door.SetActive(false);
        }
    }

    
}
