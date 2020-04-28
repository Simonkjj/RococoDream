using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // void Update()
   // public void OnMouseDown()
  //  {

  //      if (Input.touchCount > 0)

    //        Debug.Log("paused");
    //    Pause();

     //   if (GameIsPaused)
     //   {
     //       Resume();
      //  }
      //  else
      //  {
       //     Pause();
      //  }
  //  }



    //  if (Input.GetKeyDown(KeyCode.Escape))


    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;


    }

   public void Pause()
   {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0F;
        GameIsPaused = true;
   }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        Debug.Log("LOADMENU");
        SceneManager.LoadScene("Main_Menu");

    }

    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
