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
    public TextMeshProUGUI NpcLine1;
    public TextMeshProUGUI NpcLine2;
    public TextMeshProUGUI NpcLine3;
    public TextMeshProUGUI NpcLine4;
    public TextMeshProUGUI NpcLine5;
    public TextMeshProUGUI PressEsc;
    public TextMeshProUGUI UI;
    public Button Ovo_Dourado;
    public Button Proximo01;
    public Button Proximo02;
    public Button Proximo03;
    private Animator WalkingAnimator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //definindo a velocidade do walking cicle e setando a UI da caixa de dialogo para ficar invisivel 

        WalkingAnimator = GetComponent<Animator>();
        WalkingCicleAIScript.moveSpeed = 3;
        BGImage.SetActive(false);
        NpcName.enabled = false;
        NpcLine1.enabled = false;
        NpcLine2.enabled = false;
        NpcLine3.enabled = false;
        NpcLine4.enabled = false;
        NpcLine5.enabled = false;
        PressEsc.enabled = false;
        UI.enabled = false;
        Cursor.visible = false;
        Ovo_Dourado.gameObject.SetActive(false);
        Proximo01.gameObject.SetActive(false);
        Proximo02.gameObject.SetActive(false);
        Proximo03.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //quando a tecla ESC for apertada o NPC volta a andar e a caixa de dialogo fecha

        if (Input.GetKey(KeyCode.Escape))
        {
            WalkingCicleAIScript.moveSpeed = 3;
            BGImage.SetActive(false);
            NpcName.enabled = false;
            NpcLine1.enabled = false;
            NpcLine2.enabled = false;
            NpcLine3.enabled = false;
            NpcLine4.enabled = false;
            NpcLine5.enabled = false;
            PressEsc.enabled = false;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Ovo_Dourado.gameObject.SetActive(false);
            Proximo01.gameObject.SetActive(false);
            Proximo02.gameObject.SetActive(false);
            Proximo03.gameObject.SetActive(false);
        }

        if(WalkingCicleAIScript.moveSpeed == 3)
        {
            WalkingAnimator.SetFloat("Speed", 1);
        }
        if (WalkingCicleAIScript.moveSpeed == 0)
        {
            WalkingAnimator.SetFloat("Speed", 0);
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
                NpcLine1.enabled = true;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Ovo_Dourado.gameObject.SetActive(true);
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

   public void Button_One()
    {
        NpcLine1.enabled = false;
        NpcLine2.enabled = true;
        Ovo_Dourado.gameObject.SetActive(false);
        Proximo01.gameObject.SetActive(true);
    }

    public void Button_Two()
    {
        NpcLine2.enabled = false;
        NpcLine3.enabled = true;
        Proximo01.gameObject.SetActive(false);
        Proximo02.gameObject.SetActive(true);
    }

    public void Button_Three()
    {
        NpcLine3.enabled = false;
        NpcLine4.enabled = true;
        Proximo02.gameObject.SetActive(false);
        Proximo03.gameObject.SetActive(true);
    }

    public void Button_Four()
    {
        NpcLine4.enabled = false;
        NpcLine5.enabled = true;
        Proximo03.gameObject.SetActive(false);
        PressEsc.enabled = true;
    }

}
