using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnManager : MonoBehaviour
{
  public void BtnStart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainGametest");
    }

    public void BtnCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void BtnSair()
    {
        Application.Quit();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("StartScreen");
    }
}
