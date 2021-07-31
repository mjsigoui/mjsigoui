using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn_michael : MonoBehaviour
{
    int n;
    public void OnButtonPress()
    {
        n++;
    Debug.Log("Button clicked " + n + " times.");
    }
}
