using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void ExitScene()
    {
        SceneManager.LoadScene("ExitScreen");
    }
}
