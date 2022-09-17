using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject credits;
    public AudioSource StreetMusic;
    public AudioSource DoorBell;

    // Start is called before the first frame update
    void Start()
    {
        StreetMusic.Play();
        credits.SetActive(false);
    }

   public void PlayGame(string scene)
    {
        StartCoroutine(Play(scene));
    }

    public IEnumerator Play(string scene)
    {
        DoorBell.Play();
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(scene);
    }
    
    public void ToggleCredits()
    {
        if(credits.active)
        {
             credits.SetActive(false);
        }
        else
        {
            credits.SetActive(true);
        }
        
    }
}
