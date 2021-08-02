using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn_michael : MonoBehaviour
{
    private string codeFile = "code4titleScene";
    private string sceneName = "mikeScene";
    GameObject theCode;

    public void GetMikeScene()
    {
        theCode = GameObject.Find(codeFile);
        LoadDuhScene SceneLoader = theCode.GetComponent<LoadDuhScene>();
        SceneLoader.duhSceneName = sceneName;
        SceneLoader.ChangeSceneWithName();
        Debug.Log("Attempting to load the scene for Michael with name: " + SceneLoader.duhSceneName + ".");
    }
}
