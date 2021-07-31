using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadDuhScene : MonoBehaviour
{
    public string duhSceneName;
    [SerializeField] private int duhSceneNumber;

    public void ChangeSceneWithName()
    {
        SceneManager.LoadScene(duhSceneName);
        Debug.Log("Attempting to load a new screen given a name: " + duhSceneName + ".");
    }

    public void ChangeSceneWithNumber()
    {
        SceneManager.LoadScene(duhSceneNumber);
        Debug.Log("Attempting to load a new screen given a build number: " + duhSceneNumber + ".");
    }

    public void LoadNextScene()
    {
        duhSceneNumber = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(duhSceneNumber);
        Debug.Log("Attempting to load the next screen having build number: " + duhSceneNumber + ".");
    }
}
