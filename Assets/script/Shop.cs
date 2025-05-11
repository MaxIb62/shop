using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public int price = 5;
    public GameObject objectToActivate;

    public void Buy()
    {
        if (coins.instance.SpendCoins(price))
        {
            if (objectToActivate != null)
            {
                objectToActivate.SetActive(true);
                Debug.Log("Compra exitosa.");
            }
        }
    }
}