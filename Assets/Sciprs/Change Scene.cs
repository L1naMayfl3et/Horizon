using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{

    public void LoadScene()
    {
        SceneManager.LoadScene("BasicScene");
    }

    public void LoadScene2()
    {
        Application.Quit();
    }
}
