using UnityEngine;

public class FallingObstacle : MonoBehaviour
{
    [SerializeField] private float spawnTime = 5;

    private GameControl gameControl;






    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, spawnTime);
        gameControl = FindFirstObjectByType<GameControl>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerControl>() != null)
        {
            Debug.Log("Player hit");

            if (gameControl != null)
            {
                gameControl.PlayerHit();
            }

            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
