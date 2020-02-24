using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartPoints : MonoBehaviour
{
    // Start is called before the first frame update
    public int Coins = 0;
    
    public void SaveCoins()
    {
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + Coins);
    }
}
