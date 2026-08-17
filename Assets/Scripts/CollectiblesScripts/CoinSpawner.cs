using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    [SerializeField] private GameObject CoinsPrefab;
    [SerializeField] private Transform[] SpawnPoint;
    [SerializeField] private float SpawnTime = 2f;

    private GameObject CurrentCoin;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnCoins());
    }

    private IEnumerator SpawnCoins()
    {
        while (true)
        {
            if (CurrentCoin == null)
            {
                int randomIndex = Random.Range(0, SpawnPoint.Length);
                Transform spawnPoint = SpawnPoint[randomIndex];

                CurrentCoin = Instantiate(CoinsPrefab, spawnPoint.position, Quaternion.identity);
            }

            yield return new WaitForSeconds(SpawnTime);
        }
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
