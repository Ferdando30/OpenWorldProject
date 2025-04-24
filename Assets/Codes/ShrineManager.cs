using UnityEngine;

public class ShrineManager : MonoBehaviour
{
    bool completed = false;

    void OnEnable() => Collectible.OnCollected += ShrineComplete;

    void ShrineComplete()
    { 
        completed = true;
    }
}
