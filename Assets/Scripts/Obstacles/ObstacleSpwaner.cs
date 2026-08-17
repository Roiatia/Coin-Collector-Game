using System.Collections;
using UnityEngine;

public class ObstacleSpwaner : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private float spawnTime = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnObstacles());

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private IEnumerator SpawnObstacles()
    {
        while (true)
        {
            int randomIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[randomIndex];

            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity);

            yield return new WaitForSeconds(spawnTime);
        }
    }
}
