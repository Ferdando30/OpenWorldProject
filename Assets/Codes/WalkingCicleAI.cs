using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WalkingCicleAI : MonoBehaviour
{

    [SerializeField] Transform[] Points;
    [SerializeField] public float moveSpeed;

    private int pointsIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = Points[pointsIndex].transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        if (pointsIndex <= Points.Length - 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, Points[pointsIndex].transform.position, moveSpeed * Time.deltaTime);

            if (transform.position == Points[pointsIndex].transform.position)
            {
                transform.rotation = Quaternion.Euler(0, -180, 0);
                pointsIndex += 1;
            }

            if (pointsIndex == Points.Length)
            {
                pointsIndex = 0;
                transform.rotation = Quaternion.Euler(0,0,0);
            }

        }
        
    }
}
