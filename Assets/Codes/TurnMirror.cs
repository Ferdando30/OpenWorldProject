using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class TurnMirror : MonoBehaviour
{
    public float RotationTurn;
    public float RotationStart;
    public TextMeshProUGUI UI;
   // public GameObject Lights;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, RotationStart, 0);
        UI.enabled = false;
        //Lights.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider hit)
    {
        if (hit.tag == "Player")
        {
            UI.enabled = true;
            if (Input.GetKey(KeyCode.E))
            {
                transform.rotation = Quaternion.Euler(0, RotationTurn, 0);
               // Lights.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider hit)
    {
        UI.enabled = false;
    }
}
