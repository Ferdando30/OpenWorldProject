using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class CaracolColetavel : MonoBehaviour
{
    public TextMeshProUGUI UI;
    public TextMeshProUGUI text;
    public string itemID = "caracol_001";


    public static int Caracois;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UI.enabled = false;

        if (GameSessionData.Instance.itensColetados.Contains(itemID))
        {
            Destroy(gameObject); // Já foi coletado durante a sessão
            return;
        }


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
                GameSessionData.Instance.itensColetados.Add(itemID);

                Caracois = Caracois + 1;
                Destroy(gameObject);
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
