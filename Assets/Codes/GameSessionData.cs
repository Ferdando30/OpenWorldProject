using System.Collections.Generic;
using UnityEngine;

public class GameSessionData : MonoBehaviour
{
    public static GameSessionData Instance;

    public HashSet<string> itensColetados = new HashSet<string>();

    private void Awake()
    {
        // Garante que só exista um
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Mantém entre cenas
        }
        else
        {
            Destroy(gameObject); // Impede duplicatas
        }
    }
}

