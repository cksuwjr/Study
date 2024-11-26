using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    private float timeCheck;

    // Update is called once per frame
    void Update()
    {
        // Input.GetKeyDown(KeyCode.?) // 최초로 눌리는 프레임에 True 리턴

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("스페이스 Down");
            timeCheck = Time.time;
        }
        //if (Input.GetKey(KeyCode.Space)) Debug.Log("스페이스 Pressed");

        if (Input.GetKeyUp(KeyCode.Space))
        {
            //Debug.Log("스페이스 Up");
            Debug.Log(Time.time - timeCheck);
        }

        Debug.Log(Input.mousePosition);

        if (Input.GetMouseButtonDown(0)) { Debug.Log("마우스 왼 클릭 이루어졌음"); } 
        // 0: 왼클릭, 1: 오른클릭, 2: 휠클릭, 3 ~ 10 : 마우스따라 커스텀



        //float directionX = Input.GetAxisRaw("Horizontal");
        //float directionY = Input.GetAxisRaw("Vertical");

        //transform.Translate(new Vector3(directionX, directionY) * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        
    }
}
