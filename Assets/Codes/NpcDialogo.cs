using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class NpcDialogo : MonoBehaviour
{
    public WalkingCicleAI WalkingCicleAIScript;
    public GameObject BGImage;
    public TextMeshProUGUI NpcName;
    public TextMeshProUGUI NpcText;
    public TextMeshProUGUI UI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        WalkingCicleAIScript.moveSpeed = 5;
        BGImage.SetActive(false);
        NpcName.enabled = false;
        NpcText.enabled = false;
        UI.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.Escape))
        {
            WalkingCicleAIScript.moveSpeed = 5;
            BGImage.SetActive(false);
            NpcName.enabled = false;
            NpcText.enabled = false;
        }
    }
     void OnTriggerStay (Collider hit)
    {
        if(hit.tag == "Player")
        {
           UI.enabled = true;
            if (Input.GetKey(KeyCode.E))
            {
                WalkingCicleAIScript.moveSpeed = 0;
                BGImage.SetActive(true);
                NpcName.enabled = true;
                NpcText.enabled = true;
            }
        }
    }
    void OnTriggerExit (Collider hit)
    {
        if (hit.tag == "Player")
        {
            UI.enabled = false;
            
        }
    }

}
