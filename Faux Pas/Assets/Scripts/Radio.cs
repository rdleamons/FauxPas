using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    public AudioSource music;
    private bool isPlaying;
    // Start is called before the first frame update
    void Start()
    {
        isPlaying = true;
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

}
