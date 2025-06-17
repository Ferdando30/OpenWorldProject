using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class CaracolColetavel : MonoBehaviour
{
    public TextMeshProUGUI UI;
    public TextMeshProUGUI text;
   
    
    public static int Caracois;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UI.enabled = false;
        Caracois = 0;
        

    }

    // Update is called once per frame
    void Update()
    {
        text.text = Caracois.ToString();
    }

    void OnTriggerStay(Collider hit)
    {
        if(hit.tag == "Player")
        {
            UI.enabled = true;
            if (Input.GetKey(KeyCode.E))
            {
                Caracois = Caracois + 1;
                transform.position = new Vector3 (0, 0, 0);
                UI.enabled = false;
            }
        }
    }

    void OnTriggerExit(Collider hit)
    {
        if(hit.tag == "Player")
        {
            UI.enabled = false;
            
        }
    }
}
