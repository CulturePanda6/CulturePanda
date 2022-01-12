using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectionInstantiate : MonoBehaviour
{
    private ButtonController _buttonController;
    public Sprite DirectionPrefab;
    public string Name;
    public Color CurrentColor;
    void Start()
    {
       CurrentColor = new Color(1,1,1,1);
        //просто нужно для обращения к другому скрипту
        _buttonController = FindObjectOfType<ButtonController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DirectionInstantiateing()
    {
        // включаем Image внури Функциональной кнопки,для красоты
        _buttonController._imageInsideFunctionButtons[_buttonController.ButtonIndex].SetActive(true); 
        _buttonController._imageInsideFunctionButtons[_buttonController.ButtonIndex].GetComponent<Image>().color = CurrentColor;

        // присваем картинку окну функции,как на кнопке,которую мы нажали
        _buttonController._imageInsideFunctionButtons[_buttonController.ButtonIndex].GetComponent<Image>().sprite = DirectionPrefab;  
        
        // присваем имя кнопки,которую мы только что нажали выбранному окну функции
        _buttonController.StringForAnimation[_buttonController.ButtonIndex] = Name; 
       
    }
    
}
