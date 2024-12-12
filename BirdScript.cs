using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private Rigidbody2D rig;
    private Vector3 newRot;

    private void Awake()
    {
        if(TryGetComponent<Rigidbody2D>(out rig)) rig.gravityScale = 0;

        StartGame();
    }

    public void InitChar()
    {
        transform.position = Vector3.zero;
        rig.velocity = Vector3.zero;
        rig.gravityScale = 0;
        newRot = Vector3.zero;
    }

    public void StartGame()
    {
        rig.gravityScale = 1.0f;
        Time.timeScale = 1f;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rig.velocity = Vector2.zero;
            rig.AddForce(Vector2.up * 200.0f);
        }
        newRot.z = Mathf.Clamp(rig.velocity.y * 3f, -35f, 35f);
        transform.rotation = Quaternion.Euler(newRot);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DieZone"))
        {
            Debug.Log("게임 오버");
            Time.timeScale = 0f;
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("SafeZone"))
        {
            Debug.Log("점수 증가");
        }
    }
}
