using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wardrobe : MonoBehaviour
{
    public GameObject ClothingChange;
    public GameObject BodyChange;
    public GameObject FaceChange;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void openPanel(GameObject panel)
    {
        panel.SetActive(true);
    }
}
