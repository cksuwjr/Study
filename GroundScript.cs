using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class GroundScript : MonoBehaviour
{
    private Vector3 resetPos = new Vector3(15.0f, -4.5f, 0f);
    private Vector3 velocity = new Vector3(-2f, 0f, 0f);
    private bool isInit = false;

    private void Awake()
    {
        StartGame();
    }

    public void StartGame()
    {
        isInit = true;
    }

    public void EndGame()
    {
        isInit = false;
    }

    private void Update()
    {
        if (isInit)
        {
            transform.Translate(velocity * Time.deltaTime);
            if(transform.position.x < -9f)
            {
                transform.position = resetPos;
            }
        }
    }

}

