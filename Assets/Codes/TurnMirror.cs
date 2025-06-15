using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class TurnMirror : MonoBehaviour
{
    public float RotationNum;
    public TextMeshProUGUI UI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UI.enabled = false;
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
                transform.rotation = Quaternion.Euler(0, RotationNum, 0);
            }
        }
    }

    void OnTriggerExit(Collider hit)
    {
        UI.enabled = false;
    }
}
