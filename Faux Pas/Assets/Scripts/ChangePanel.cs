using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanel : MonoBehaviour
{
    public GameObject ClothingChange;
    public GameObject BodyChange;
    public GameObject FaceChange;


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

    public void openTab(GameObject tab, GameObject tab2, GameObject tab3)
    {
        tab.SetActive(true);
        tab2.SetActive(false);
        tab3.SetActive(false);
    }
}
