using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    public AudioSource music;
    public AudioSource doorbell;
    private bool isPlaying;

    public GameObject polaroid;
    public GameObject polaroidPanel;

    // Start is called before the first frame update
    void Start()
    {
        isPlaying = true;
        polaroid.SetActive(false);
        polaroidPanel.SetActive(false);
    }

    public void toggleRadio()
    {
        if(isPlaying)
        {
            music.Pause();
            isPlaying = false;
        }
        else
        {
            music.Play();
            isPlaying = true;
        }
    }


    public void ExitSalon()
    {
        StartCoroutine(Exit());
    }

    public IEnumerator Exit()
    {

        doorbell.Play();
        yield return new WaitForSeconds(2f);
        polaroid.SetActive(true);
        polaroidPanel.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
