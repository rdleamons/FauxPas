using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanelTab : MonoBehaviour
{
    public GameObject ClothingChange;
    public GameObject BodyChange;
    public GameObject FaceChange;
    public GameObject secondTab;
    public GameObject thirdTab;
    public GameObject fourthTab;
    public GameObject fifthTab;


    // Start is called before the first frame update
    void Start()
    {
        ClothingChange.SetActive(false);
        BodyChange.SetActive(false);
        FaceChange.SetActive(false);
        secondTab.SetActive(false);
        thirdTab.SetActive(false);
        fourthTab.SetActive(false);
        fifthTab.SetActive(false);
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
}
