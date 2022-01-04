using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    private ButtonController _buttonController;
    public int NumberOfButton;
    
    
    void Start()
    {
        _buttonController = FindObjectOfType<ButtonController>(); // просто нужно,чтобы обращаться к дргуому скрипту
    }


    void Update()
    {
        
    }
    
    public void ButtonChangeColor()
    {
        this.GetComponent<Image>().color = new Color(0.5f, 0.5f, 0.5f); // перекрашиваем кнопку,по которой кликнули в серый цвет
        _buttonController.ButtonIndex = NumberOfButton; // сообщаем номер кнопки по которой кликнули в другой скипт ButtonController(в инспекторе у каждой кнопки нужно выставить индекс)
    }
    
   
}
