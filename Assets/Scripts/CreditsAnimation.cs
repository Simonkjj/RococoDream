using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsAnimation : MonoBehaviour
{
    public void ReturnMainmenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}
