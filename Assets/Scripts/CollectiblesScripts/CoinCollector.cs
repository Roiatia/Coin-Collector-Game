using UnityEngine;

public class CoinCollector : MonoBehaviour
{

    private GameControl gameControl;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerControl>() != null)
        {
            if (gameControl != null)
            {
                gameControl.addCoins();
            }

            Destroy(gameObject);
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameControl = FindFirstObjectByType<GameControl>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
