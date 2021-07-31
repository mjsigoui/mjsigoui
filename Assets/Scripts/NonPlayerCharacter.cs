using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonPlayerCharacter : MonoBehaviour
{

    public float displayTime = 4.0f;
    public GameObject dialogBox;
    GameObject duhMusic;
    float timerDisplay;

    AudioSource audioSource, backGroundMusic;

    // Start is called before the first frame update
    void Start()
    {
        dialogBox.SetActive(false);
        timerDisplay = -1.0f;

        audioSource= GetComponent<AudioSource>();
        duhMusic = GameObject.Find("BackgroundMusic");
        backGroundMusic = duhMusic.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerDisplay >= 0)
        {
            timerDisplay -= Time.deltaTime;
            if (timerDisplay < 0)
            {
                dialogBox.SetActive(false);
            }
        }
    }

    public void DisplayDialog()
    {
        timerDisplay = displayTime;
        dialogBox.SetActive(true);

        backGroundMusic.enabled = false;
        audioSource.PlayDelayed(0);
        StartCoroutine(LetsPlay());
        //backGroundMusic.PlayDelayed(audioSource.clip.length);

    }

    IEnumerator LetsPlay()
    {
        yield return new WaitForSeconds(75);
        backGroundMusic.enabled = true;
    }
}
