using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipeFrepab;
    private WaitForSeconds wfs = new WaitForSeconds(2f);
    private Vector3 spawnPos = new Vector3(5f, 0f, 0f);

    private void Awake()
    {
        GameStart();
    }

    public void GameStart()
    {
        StartCoroutine("SpawnPipe");
    }

    public void EndGame()
    {
        StopCoroutine("SpawnPipe");
    }

    IEnumerator SpawnPipe()
    {
        while (true)
        {
            spawnPos.y = Random.Range(-1f, 3f);
            Instantiate(pipeFrepab, spawnPos, Quaternion.identity);
            yield return wfs;
        }
    }

}
