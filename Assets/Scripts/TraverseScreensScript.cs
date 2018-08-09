using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class TraverseScreensScript : MonoBehaviour
{

    public int sceneToLoad = 0;

    private void OnGUI()
    {
        sceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
        if (SceneManager.GetActiveScene().buildIndex + 1 >= SceneManager.sceneCountInBuildSettings)
        {
            sceneToLoad = 0;
        }

        GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height - 80, 100, 30), "Current Scene: " + SceneManager.GetActiveScene().buildIndex);
        //GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height - 65, 100, 30), "Scene to load: " + sceneToLoad);

        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height - 50, 100, 40), "Load Scene " + (sceneToLoad)))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
