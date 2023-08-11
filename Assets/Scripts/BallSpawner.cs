using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public Vector3 originPoint = new Vector3(0,0,0);
    public List<GameObject> prefabs;

    public float interval = 1f;
    private float spawnCooldown = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnCooldown -= Time.deltaTime;

        if(spawnCooldown <= 0)
        {
            spawnCooldown = interval;
            SpawnBall();
        }
    }

    private void SpawnBall()
    {   
        int prefabIndex = Random.Range(0, prefabs.Count);
        GameObject prefab = prefabs[prefabIndex];

        float gameWidth = GameManager.Instance.gameWidth;
        float xOffset = Random.Range(-gameWidth / 2f, gameWidth /2f);


        Vector3 position = originPoint + new Vector3(xOffset,0,0);
        Quaternion rotation = prefab.transform.rotation;

        Instantiate(prefab, position, rotation);
    }
}
