using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class NpcDialogo : MonoBehaviour
{
   //definindo as variaveis para a UI da caixa de dialogo e puxando o script do walking cicle do npc
    
    public WalkingCicleAI WalkingCicleAIScript;
    public GameObject BGImage;
    public TextMeshProUGUI NpcName;
    public TextMeshProUGUI NpcText;
    public TextMeshProUGUI UI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       //definindo a velocidade do walking cicle e setando a UI da caixa de dialogo para ficar invisivel 
        
        WalkingCicleAIScript.moveSpeed = 5;
        BGImage.SetActive(false);
        NpcName.enabled = false;
        NpcText.enabled = false;
        UI.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //quando a tecla ESC for apertada o NPC volta a andar e a caixa de dialogo fecha

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
       //quando o player entrar no trigger box do NPC vai aparecer a opção de clicar na tecla E para começar o dialogo

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
       //quando o player sair do trigger box, a opçao de clicar na tecla E desaparece 
        
        if (hit.tag == "Player")
        {
            UI.enabled = false;
            
        }
    }

}
