using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject ObstaclePrefab;
    public float SpawnInterval = 2f;
    public float SpawnHeightMin = -2f;
    public float SpawnHeightMax = 3f;
    public float MoveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObstacles());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnObstacles()
    {
        while(true)
        {
            float SpawnY = Random.Range(SpawnHeightMin, SpawnHeightMax);
            Vector3 spawnPosition = new Vector3(10, SpawnY, 0);
            GameObject Obstacle = Instantiate(ObstaclePrefab, spawnPosition, Quaternion.identity);

            Rigidbody2D rb = Obstacle.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(-MoveSpeed, 0);

            yield return new WaitForSeconds(SpawnInterval);
        }
    }

}
