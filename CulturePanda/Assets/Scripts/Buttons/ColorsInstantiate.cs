using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorsInstantiate : MonoBehaviour
{
    private ButtonController _buttonController;
    public Color CurrentColor;
    public string CurrentTag;
    
    void Start()
    {
        //просто нужно для обращения к другому скрипту
        _buttonController = FindObjectOfType<ButtonController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ColorInstantiateing()
    {
        // включаем Image внури Функциональной кнопки,для красоты
        _buttonController._ConstatintcolorsInsideFunctionButtons[_buttonController.ButtonIndex].SetActive(true); 
        _buttonController._colorsInsideFunctionButtons[_buttonController.ButtonIndex].SetActive(true);
        CurrentColor.a = 1;

        // присваем цвет окну функции,как на кнопке,которую мы нажали
        _buttonController._colorsInsideFunctionButtons[_buttonController.ButtonIndex].GetComponent<Image>().color = CurrentColor; 
        _buttonController._ConstatintcolorsInsideFunctionButtons[_buttonController.ButtonIndex].GetComponent<Image>().color = CurrentColor;
        _buttonController._colorsInsideFunctionButtons[_buttonController.ButtonIndex].tag = CurrentTag;
    }

}
