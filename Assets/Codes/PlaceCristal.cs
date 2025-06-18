using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class PlaceCristal : MonoBehaviour
{
    public Cristal CristalScript;
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
        if(hit.tag == "Player")
        {
            UI.enabled = true;
            if(CristalScript.CristalColetado == true)
            {
                if(Input.GetKey(KeyCode.E))
                {
                    CristalScript.outroCristal.SetActive(true);
                }
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
