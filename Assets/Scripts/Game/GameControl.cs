using UnityEngine;

public class GameControl : MonoBehaviour
{

    [SerializeField] private int CoinsToCollect = 6;
    private int CoinsCollected;


    public void addCoins ()
    {
        CoinsCollected++;
        if (CoinsCollected >= CoinsToCollect)
        {
            Debug.Log("All coins collected");

            if(CoinsCollected >= CoinsToCollect) {
                Debug.Log("YOU WIN !");
            }
           }
       }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
