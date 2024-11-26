using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFinder : MonoBehaviour
{
    private void OnEnable()
    {
        GameObject obj;
        
        obj = GameObject.Find("Square");
        // Find �Լ��� ������ ��������.
        // => �̸��� ���� ã�� ��

        obj = GameObject.FindGameObjectWithTag("Enemy");

        GameObject[] objs = GameObject.FindGameObjectsWithTag("Enemy");
        // ����Ƽ���� �迭�� ����� ���� �迭 (like �ڷᱸ�� ����)


        // foreach �� ����ϱ�� ���ϰ� �ڵ尡 �����ϳ� for������ ������ ������..
        foreach(GameObject ob in objs)
        {
            Debug.Log(ob.name);
        }

        if (obj) obj.GetComponent<SpriteRenderer>().color = Random.ColorHSV();
    }

}
