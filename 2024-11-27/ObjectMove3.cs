using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove3 : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 7f;
    private Vector3 moveDir;
    private CharacterController charCont;

    private void Awake()
    {
        // ≈€«√∏¥?
        charCont = gameObject.AddComponent<CharacterController>();
    }

    private void Update()
    {
        moveDir.x = Input.GetAxisRaw("Horizontal");
        moveDir.y = Input.GetAxisRaw("Vertical");
        moveDir.z = 0;

        moveDir.Normalize();

        charCont.Move(moveSpeed * Time.deltaTime * moveDir);
    }
}
