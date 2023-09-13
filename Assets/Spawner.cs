using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] puntos;
    private float time2Spawn;
    private float timer = 0;
    private float rmdYaxisPos;
    private float rmdXaxisPos;

    void Update()
    {
        timer += Time.deltaTime;
        time2Spawn = Random.Range(1f, 3f);

        if (timer >= time2Spawn)
        {
            float rmdYaxisPos = Random.Range(-4.7f, 4.7f);
            float rmdXaxisPos = Random.Range(-8.5f, 8.5f);
            Vector3 spawnPos = new Vector3(rmdXaxisPos, rmdYaxisPos);

            int rmdIndex = Random.Range(0, puntos.Length);

            Instantiate(puntos[rmdIndex],spawnPos, Quaternion.identity);
            
            timer = 0;
        }
    }

}
