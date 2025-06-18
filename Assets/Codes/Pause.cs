using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class Pause : MonoBehaviour
{
    public GameObject BGImage;
    public Button Resume;
    public Button Menu;
    public TextMeshProUGUI PauseText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BGImage.SetActive(false);
        Resume.gameObject.SetActive(false);
        Menu.gameObject.SetActive(false);
        PauseText.enabled = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            BGImage.SetActive(true);
            Resume.gameObject.SetActive(true);
            Menu.gameObject.SetActive(true);
            PauseText.enabled = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
        }
    }

    public void ResumeBtn()
    {
        Time.timeScale = 1;
        BGImage.SetActive(false);
        Resume.gameObject.SetActive(false);
        Menu.gameObject.SetActive(false);
        PauseText.enabled = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
    }
}
