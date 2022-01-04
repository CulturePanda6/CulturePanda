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
        
        _buttonController = FindObjectOfType<ButtonController>();//просто нужно для обращения к другому скрипту
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ColorInstantiateing()
    {
        _buttonController._ConstatintcolorsInsideFunctionButtons[_buttonController.ButtonIndex].SetActive(true); // включаем Image внури Функциональной кнопки,для красоты
        _buttonController._colorsInsideFunctionButtons[_buttonController.ButtonIndex].SetActive(true);
        CurrentColor.a = 1;
        _buttonController._colorsInsideFunctionButtons[_buttonController.ButtonIndex].GetComponent<Image>().color = CurrentColor; // присваем цвет окну функции,как на кнопке,которую мы нажали
        _buttonController._ConstatintcolorsInsideFunctionButtons[_buttonController.ButtonIndex].GetComponent<Image>().color = CurrentColor;
        _buttonController._colorsInsideFunctionButtons[_buttonController.ButtonIndex].tag = CurrentTag;
    }

}
