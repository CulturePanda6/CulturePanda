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
        // просто нужно,чтобы обращаться к дргуому скрипту
        _buttonController = FindObjectOfType<ButtonController>(); 
        
    }


    void Update()
    {
        
    }
    
    public void ButtonChangeColor()
    {
        // перекрашиваем кнопку,по которой кликнули в серый цвет
        this.GetComponent<Image>().color = new Color(0.5f, 0.5f, 0.5f);
        // сообщаем номер кнопки по которой кликнули в другой скипт
        // ButtonController(в инспекторе у каждой кнопки нужно выставить индекс)
        _buttonController.ButtonIndex = NumberOfButton; 
    }
    
   
}
