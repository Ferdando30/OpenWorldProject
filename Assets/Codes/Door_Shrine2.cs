using UnityEngine;

public class Door_Shrine2 : MonoBehaviour
{
   //definindo variaveis dos objetos dos 5 inimigos e da porta
    
    public GameObject Enemy1;
    

    public GameObject door;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        door.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
       //definindo que quando todos os inimigos forem mortos a porta ira abrir
        
        if(Enemy1 == null)
        {
            door.SetActive(false);
        }
        
    }
}
