using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanelTab : MonoBehaviour
{
    public GameObject ClothingChange;
    public GameObject BodyChange;
    public GameObject FaceChange;
    public GameObject[] tab;


    // Start is called before the first frame update
    void Start()
    {
        ClothingChange.SetActive(false);
        BodyChange.SetActive(false);
        FaceChange.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void openPanel(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void closePanel(GameObject panel)
    {
        panel.SetActive(false);
    }

    public void openTab(GameObject currTab)
    {
        if(currTab == tab[0])
        {
            tab[0].SetActive(true);
            tab[1].SetActive(false);
            tab[2].SetActive(false);
        }
        else if(currTab == tab[1])
        {
            tab[0].SetActive(false);
            tab[1].SetActive(true);
            tab[2].SetActive(false);
        }
        else if(currTab == tab[2])
        {
            tab[0].SetActive(false);
            tab[1].SetActive(false);
            tab[2].SetActive(true);
        }
    }
}
