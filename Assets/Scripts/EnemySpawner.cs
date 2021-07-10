using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float intervalTime = 1f;

    public float SpawnRange = 10f;

    // Update is called once per frame
    void Start()
    {
        Invoke("Spawn", intervalTime);
    }

    void Spawn()
    {
        Vector3 pos = transform.position;

        pos.x = Random.Range(SpawnRange, -SpawnRange);
        Instantiate(enemy, pos, Quaternion.identity);
        Invoke("Spawn", intervalTime);
    }
}
