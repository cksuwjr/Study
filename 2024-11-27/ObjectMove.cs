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
    //    // ��ǻ�Ϳ��� w ����Ͽ��� ��ġ, Xbox������ ���̽�ƽ...
    //    // ���� ��ǲ���� �ٸ��� ������ ������ �ϴ� ���

    //    // ���� ���� �̷������ �ϳ��� �ൿ�� �������� Ű�� �����Ͽ� ����� �� �ִ� ��� : Input Manager( Project Setting - ..)

    //    float inputX = Input.GetAxis("Horizontal");
    //    float inputY = Input.GetAxis("Vertical");

    //    inputX = Input.GetAxisRaw("Horizontal");
    //    inputY = Input.GetAxisRaw("Vertical");

    //    // AxisRaw �� Axis�� ���̴� float�� ������������ ���� ����    1.00, 0.00   0.90  0.80  0.20 0.10



    //    moveDir = new Vector3(inputX, inputY, 0).normalized;
    //    moveDir = moveSpeed * Time.deltaTime * moveDir;

    //    // �Ʒ��� ����
    //    transform.Translate(moveDir);
    //    transform.position += moveDir;
    //}

    private void Update()
    {
        // ���� ����?


        // ��ũ�� �����̽� ��ǥ�� ���� �����̽� ��ǥ�� ��ȯ �ʿ�
        // ��ũ�� ��ǥ -> ��ǥƮ ��ǥ -> ���� ��ǥ
        // ����Ƽ������ �� ����� ����

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(Input.mousePosition); // ���콺�� ��ǥ�� Screen Space ��ǥ��
            moveTargetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // ScreenWorldPoint�� z���� �⺻���� 0�̰� �ٸ� ������Ʈ ������ �ش� ������Ʈ z�� �������� �Ǿ�����
            // ���� �� z�� �����ǵ��� ��ȭ���������
            moveTargetPos.z = transform.position.z;

        }
        // ���������� ���� �̵�
        transform.position = Vector3.Lerp(transform.position, moveTargetPos, moveSpeed * Time.deltaTime);
    }
}
