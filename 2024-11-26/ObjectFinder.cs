using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFinder : MonoBehaviour
{
    private void OnEnable()
    {
        GameObject obj;
        
        obj = GameObject.Find("Square");
        // Find 함수는 성능이 떨어진다.
        // => 이름을 통해 찾는 것

        obj = GameObject.FindGameObjectWithTag("Enemy");

        GameObject[] objs = GameObject.FindGameObjectsWithTag("Enemy");
        // 유니티에서 배열을 만들면 동적 배열 (like 자료구조 벡터)


        // foreach 는 사용하기는 편하고 코드가 간결하나 for문보다 성능이 안좋다..
        foreach(GameObject ob in objs)
        {
            Debug.Log(ob.name);
        }

        if (obj) obj.GetComponent<SpriteRenderer>().color = Random.ColorHSV();
    }

}
