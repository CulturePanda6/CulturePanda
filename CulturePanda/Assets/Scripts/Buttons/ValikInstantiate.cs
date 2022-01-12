using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValikInstantiate : MonoBehaviour
{
    private ButtonController _buttonController;
    public Sprite DirectionPrefab;
    public Color CurrentColor;

    public string Name;
    void Start()
    {
        //need to cause another script
        _buttonController = FindObjectOfType<ButtonController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ValikColorInstantiateing()
    {
        // turn on Image inside functional button, optional
        _buttonController._imageInsideFunctionButtons[_buttonController.ButtonIndex].SetActive(true); 
        CurrentColor.a = 1;
        _buttonController._imageInsideFunctionButtons[_buttonController.ButtonIndex].GetComponent<Image>().color = CurrentColor;

        // assign a picture to the window of function like on the pressed button
        _buttonController._imageInsideFunctionButtons[_buttonController.ButtonIndex].GetComponent<Image>().sprite = DirectionPrefab;  

        // assign the name of the pressed button to choosen function window
        _buttonController.StringForAnimation[_buttonController.ButtonIndex] = Name; 
    }
}
