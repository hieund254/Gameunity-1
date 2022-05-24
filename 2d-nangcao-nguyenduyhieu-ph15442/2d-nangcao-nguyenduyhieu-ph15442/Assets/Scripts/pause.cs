using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
   public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        
    }

   public void Resume()
   {
       pauseMenu.SetActive(false);
       Time.timeScale = 1f;
   }
    // Update is called once per frame
   public void Home(int sceneID)
   {
       Time.timeScale = 1f;
       SceneManager.LoadScene(sceneID);
   }
}
