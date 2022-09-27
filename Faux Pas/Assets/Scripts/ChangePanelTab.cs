using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanelTab : MonoBehaviour
{
    public GameObject ClothingChange;
    public GameObject ShoeChange;

    public GameObject BodyChange;
    public GameObject FaceChange;

    public GameObject HairChange;

    public GameObject[] tabs;

    public GameObject salonLeft;
    public GameObject salonRight;


    // Start is called before the first frame update
    void Start()
    {
        salonLeft.SetActive(false);
        salonRight.SetActive(false);

        ClothingChange.SetActive(false);
        ShoeChange.SetActive(false);

        BodyChange.SetActive(false);
        FaceChange.SetActive(false);

        HairChange.SetActive(false);

        for (int i = 0; i <= tabs.Length; i++)
        {
            tabs[i].SetActive(false);
        }
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
