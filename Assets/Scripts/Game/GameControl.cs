using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{

    [SerializeField] private int CoinsToCollect = 10;
    [SerializeField] private int lives = 3;

    private int CoinsCollected;
    private bool gameEnded = false;


    public void PlayerHit()
    {
        if (gameEnded)
        {
            return;
        }

        lives--;

        Debug.Log("Lives: " + lives);

        if (lives <= 0)
        {
            Debug.Log("YOU LOSE!");
            gameEnded = true;
            Time.timeScale = 0f;
        }
    }
    public void addCoins()
    {
        if (gameEnded)
        {
            return;
        }

        CoinsCollected++;

        Debug.Log("Coins: " + CoinsCollected + "/" + CoinsToCollect);

        if (CoinsCollected >= CoinsToCollect)
        {
            Debug.Log("All coins collected");
            Debug.Log("YOU WIN!");

            gameEnded = true;

            Time.timeScale = 0f;
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1f;

    }

    // Update is called once per frame
    void Update()
    {
        if (gameEnded && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
