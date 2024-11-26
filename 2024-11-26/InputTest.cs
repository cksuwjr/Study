using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    private float timeCheck;

    // Update is called once per frame
    void Update()
    {
        // Input.GetKeyDown(KeyCode.?) // ���ʷ� ������ �����ӿ� True ����

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("�����̽� Down");
            timeCheck = Time.time;
        }
        //if (Input.GetKey(KeyCode.Space)) Debug.Log("�����̽� Pressed");

        if (Input.GetKeyUp(KeyCode.Space))
        {
            //Debug.Log("�����̽� Up");
            Debug.Log(Time.time - timeCheck);
        }

        Debug.Log(Input.mousePosition);

        if (Input.GetMouseButtonDown(0)) { Debug.Log("���콺 �� Ŭ�� �̷������"); } 
        // 0: ��Ŭ��, 1: ����Ŭ��, 2: ��Ŭ��, 3 ~ 10 : ���콺���� Ŀ����



        //float directionX = Input.GetAxisRaw("Horizontal");
        //float directionY = Input.GetAxisRaw("Vertical");

        //transform.Translate(new Vector3(directionX, directionY) * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        
    }
}
