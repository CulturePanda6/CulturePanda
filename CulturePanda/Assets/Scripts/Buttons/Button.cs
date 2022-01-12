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
        _buttonController = FindObjectOfType<ButtonController>();    
    }


    void Update()
    {
        
    }
    
    public void ButtonChangeColor()
    {
        // pained pressed button to the grey color
        this.GetComponent<Image>().color = new Color(0.5f, 0.5f, 0.5f);
        // send the number of the pressed button to another script
        // ButtonController(in inspector for each button need to set index)
        _buttonController.ButtonIndex = NumberOfButton; 
    }
    
   
}
