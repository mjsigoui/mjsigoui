using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn_home : MonoBehaviour
{
    private string codeFile = "code4chrisScene";
    GameObject theCode;

    public void GetTitleScene()
    {
        theCode = GameObject.Find(codeFile);
        LoadDuhScene SceneLoader = theCode.GetComponent<LoadDuhScene>();
        SceneLoader.duhSceneName = "titleScene";
        SceneLoader.ChangeSceneWithName();
        Debug.Log("Attempting to load the main home scene from chrisScene with name: " + SceneLoader.duhSceneName + ".");
    }
    
}
