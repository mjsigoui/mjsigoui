using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn_chris : MonoBehaviour
{
    private string codeFile = "code4titleScene";
    GameObject theCode;

    public void GetChrisScene()
    {
        theCode = GameObject.Find(codeFile);
        LoadDuhScene SceneLoader = theCode.GetComponent<LoadDuhScene>();
        SceneLoader.duhSceneName = "chrisScene";
        SceneLoader.ChangeSceneWithName();
        Debug.Log("Attempting to load the scene for Chris with name: " + SceneLoader.duhSceneName + ".");
    }
    
}
