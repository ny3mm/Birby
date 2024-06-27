using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public TMP_Text coinText;
    public int currentCoins = 0;
    private static CoinCounter _instance;

    public static CoinCounter Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("CoinCounter is null");
            }

            return _instance;
        }
    }

    private void Awake()
        {
            _instance = this;
        Debug.Log(gameObject.name+coinText);
        }

    public void AddCoin()
    {
        currentCoins++;
        coinText.text = "COINS: " + currentCoins.ToString();
    }
}
