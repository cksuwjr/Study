using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove2 : MonoBehaviour
{
    private bool isSelect;

    private void Start()
    {
        isSelect = false;
    }



    private void Update()
    {
        if (isSelect)
        {
            Vector3 newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            newPos.z = transform.position.z;

            transform.position = newPos;
        }
    }

    private void OnMouseDown()
    {
        isSelect = true;
    }

    private void OnMouseUp()
    {
        isSelect = false;
    }
}
