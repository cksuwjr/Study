using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private GameObject picture;

    void Start()
    {
        //int i = 0;
        //Quaternion angle;
        //while(i < 5)
        //{
        //    angle = Quaternion.Euler(new Vector3(0, 0, 30 * (1 - 0.5f * i)));
        //    Instantiate(picture, new Vector3(-4 + i * 2, 0, 0), angle);
        //    i++;
        //}

        Vector3 spawnPos;
        Quaternion spawnRot;

        for(int i = 0; i < 5; i++)
        {
            spawnPos.x = -7f + (3.5f * i);
            spawnPos.y = 0f;
            spawnPos.z = 0f;

            spawnRot = Quaternion.Euler(0f, 0f, (30f - 15 * i));

            Instantiate(picture, spawnPos, spawnRot);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
