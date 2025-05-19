using UnityEngine;

public class NpcDialogo : MonoBehaviour
{
    public WalkingCicleAI WalkingCicleAIScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        WalkingCicleAIScript.moveSpeed = 6;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            WalkingCicleAIScript.moveSpeed = 0;
        }
    }
}
