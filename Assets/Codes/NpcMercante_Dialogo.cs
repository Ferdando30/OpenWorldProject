using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class NpcMercante_Dialogo : MonoBehaviour
{
    public GameObject BGImage;
    public TextMeshProUGUI NpcName;
    public TextMeshProUGUI UI;
    public TextMeshProUGUI PressEsc;
    public TextMeshProUGUI NpcLine1;
    public TextMeshProUGUI NpcLine2;
    public TextMeshProUGUI NpcLine3;
    public Button Proximo01;
    public Button Proximo02;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BGImage.SetActive(false);
        NpcName.enabled = false;
        NpcLine1.enabled = false;
        NpcLine2.enabled = false;
        NpcLine3.enabled = false;
        PressEsc.enabled = false;
        UI.enabled = false;
        Proximo01.gameObject.SetActive(false);
        Proximo02.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            BGImage.SetActive(false);
            NpcName.enabled = false;
            NpcLine1.enabled = false;
            NpcLine2.enabled = false;
            NpcLine3.enabled = false;
            PressEsc.enabled = false;
            UI.enabled = false;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Proximo01.gameObject.SetActive(false);
            Proximo02.gameObject.SetActive(false);
        }
    }
    void OnTriggerStay(Collider hit)
    {
        if(hit.tag == "Player")
        {
            UI.enabled = true;
            if (Input.GetKey(KeyCode.E))
            {
                BGImage.SetActive(true);
                NpcName.enabled = true;
                NpcLine1.enabled = true;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Proximo01.gameObject.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider hit)
    {
        UI.enabled = false;
    }

    public void Proximo1()
    {
        NpcLine1.enabled = false;
        NpcLine2.enabled = true;
        Proximo01.gameObject.SetActive(false);
        Proximo02.gameObject.SetActive(true);
    }

    public void Proximo2()
    {
        NpcLine2.enabled = false;
        NpcLine3.enabled = true;
        Proximo02.gameObject.SetActive(false);
        PressEsc.enabled = true;
    }
}
