using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coins : MonoBehaviour
{
    public static coins instance;

    public int coin = 0;

    public TextMeshProUGUI coinText;
    // Start is called before the first frame update

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Coin")
        {
            coin++;
            coinText.text = "coins: " + coin.ToString();
            Debug.Log(coin);
            Destroy(other.gameObject);
        }
    }

    public bool SpendCoins(int amount)
    {
        if (coin >= amount)
        {
            coin -= amount;
            coinText.text = "coins: " + coin.ToString();
            return true;
        }
        else
        {
            Debug.Log("No hay monedas");
            return false;
        }
    }
}
