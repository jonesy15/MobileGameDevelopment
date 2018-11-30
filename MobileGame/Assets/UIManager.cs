using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
