using UnityEngine;

public class Door_Shrine2 : MonoBehaviour
{
   //definindo variaveis dos objetos dos 5 inimigos e da porta
    
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject Enemy5;

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
        
        if(Enemy1 == null && Enemy2 == null && Enemy3 == null && Enemy4 == null && Enemy5 == null)
        {
            door.SetActive(false);
        }
        
    }
}
