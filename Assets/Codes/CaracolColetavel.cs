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

        if (PlayerPrefs.GetInt("Item_" + itemID, 0) == 1)
        {
            Destroy(gameObject); // Já foi coletado antes
            return; // sair do Start
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
                PlayerPrefs.SetInt("Item_" + itemID, 1);
                PlayerPrefs.Save();

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
