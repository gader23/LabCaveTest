using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public TextMeshProUGUI textCoin;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name=="Kart")
        {
           this.gameObject.SetActive(false);
            other.GetComponent<KartPoints>().Coins++;
            textCoin.text = "Coins: " + other.GetComponent<KartPoints>().Coins.ToString();
        }
    }
}
