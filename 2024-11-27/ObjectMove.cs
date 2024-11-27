using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private Vector3 moveDir;
    private Vector3 moveTargetPos = Vector3.zero;
    private float currentTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{
    //    // 컴퓨터에서 w 모바일에서 터치, Xbox에서는 조이스틱...
    //    // 서로 인풋값이 다르나 동일한 동작을 하는 기능

    //    // 게임 내에 이루어지는 하나의 행동에 여러가지 키를 매핑하여 사용할 수 있는 기능 : Input Manager( Project Setting - ..)

    //    float inputX = Input.GetAxis("Horizontal");
    //    float inputY = Input.GetAxis("Vertical");

    //    inputX = Input.GetAxisRaw("Horizontal");
    //    inputY = Input.GetAxisRaw("Vertical");

    //    // AxisRaw 와 Axis의 차이는 float값 딱떨어지느냐 마냐 차이    1.00, 0.00   0.90  0.80  0.20 0.10



    //    moveDir = new Vector3(inputX, inputY, 0).normalized;
    //    moveDir = moveSpeed * Time.deltaTime * moveDir;

    //    // 아래는 같다
    //    transform.Translate(moveDir);
    //    transform.position += moveDir;
    //}

    private void Update()
    {
        // 선형 보간?


        // 스크린 스페이스 좌표를 월드 스페이스 좌표로 변환 필요
        // 스크린 좌표 -> 뷰표트 좌표 -> 월드 좌표
        // 유니티에서는 위 기능을 제공

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(Input.mousePosition); // 마우스의 좌표는 Screen Space 좌표계
            moveTargetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // ScreenWorldPoint의 z축의 기본값은 0이고 다른 오브젝트 닿으면 해당 오브젝트 z값 가져오게 되어있음
            // 따라서 현 z값 유지되도록 변화시켜줘야함
            moveTargetPos.z = transform.position.z;

        }
        // 선형보간을 통한 이동
        transform.position = Vector3.Lerp(transform.position, moveTargetPos, moveSpeed * Time.deltaTime);
    }
}
