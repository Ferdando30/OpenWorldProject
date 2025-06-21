using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class Cristal : MonoBehaviour
{
    public bool CristalColetado;
    public GameObject outroCristal;
    public TextMeshProUGUI UI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CristalColetado = false;
        outroCristal.SetActive(false);
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
                CristalColetado = true;
                transform.position = new Vector3(0, -500, 0);
                UI.enabled = false;
            }
        }
    }

    void OnTriggerExit(Collider hit)
    {
        if (hit.tag == "Player")
        {
            UI.enabled = false;

        }
    }
}
