using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    private Vector3 velocity = new Vector3(-2f, 0f, 0f);

    private void Update()
    {
        transform.Translate(velocity * Time.deltaTime);

        if (transform.position.x < -5f)
            Destroy(gameObject);
    }
}
