using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour
{
    public GameObject victory;
    public CoinManager Coin;

    
    void Update()
    {
        if(Coin.coinCount == 156) //the amount of coins/dots on the map
        {
            Time.timeScale = 0;
            victory.SetActive(true);
        }
    }
}
