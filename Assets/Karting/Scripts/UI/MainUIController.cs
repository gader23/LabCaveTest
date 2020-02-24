using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace KartGame.UI
{
    /// <summary>
    /// A MonoBehaviour for controlling the different panels of the main menu.
    /// </summary>
    public class MainUIController : MonoBehaviour
    {
        [Tooltip("A collection of UI panels, one of which will be active at a time.")]
        public GameObject[] panels;


      public  void PlayAgain()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

     public  void MainMenu()
        {
            SceneManager.LoadScene(0);
        }
    }


}