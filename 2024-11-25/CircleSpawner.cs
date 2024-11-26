using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject circlePrefab;

    // Update is called once per frame
    void Update()
    {
        if(circlePrefab != null)
        {
            Vector3 randomPos = new Vector3(Random.Range(-3f, 3f), Random.Range(-2f, 2f), 0f);

            //Instantiate(circlePrefab, randomPos, Quaternion.identity); // ������ ������ �����ϱ� ���� ���ʹϾ��̶�� ȸ������� ����Ѵ�.
            
            
            Quaternion spawnRot = Quaternion.Euler(0f, 0f, 30f);
            Instantiate(circlePrefab, randomPos, spawnRot);
            
        }
    }
}
