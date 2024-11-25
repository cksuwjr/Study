using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Cos 90도" + Mathf.Cos(90 * Mathf.Deg2Rad));
        Debug.Log("Sin 90도" + Mathf.Sin(90 * Mathf.Deg2Rad));
        //Mathf.Tan();
        //Mathf.Atan();
        //Mathf.Atan2();
        //Mathf.Acos();

        Mathf.Clamp(100, 10, 50); // clamp min 과 max 사이의 값으로 조정하는 함수

        // 리플레이 : 시드값 관리
        Random.InitState(5); 

        for(int i = 0; i < 10; i++) Debug.Log(Random.Range(5, 25));
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time);

        //Time.timeScale = 1.0f;
    }
}
