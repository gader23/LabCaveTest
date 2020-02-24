using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI time;
    public TextMeshProUGUI coins;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    void Start()
    {
       
        
            time.text = "Best Time: " + PlayerPrefs.GetFloat("Time",0).ToString();
        coins.text = "Total Coins: " + PlayerPrefs.GetInt("Coins", 0).ToString();
        
    }
}
