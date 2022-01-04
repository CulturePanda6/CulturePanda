using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] public GameObject[] _functionsButtons;
    public int ButtonIndex;
    [SerializeField] public GameObject[] _imageInsideFunctionButtons;
    public GameObject[] _colorsInsideFunctionButtons;
    public GameObject[] _ConstatintcolorsInsideFunctionButtons;
    public string[] StringForAnimation;
    void Start()
    {
        
    }


    void Update()
    {
        
    }
    
    public void ClicInFuctionButton()
    {
        for(int i = 0; i < _functionsButtons.Length; i++) // все кнопки перекрашиваются в стандартный цвет,для того,чтобы одна только кнопка была серым цветом
        {
            _functionsButtons[i].GetComponent<Image>().color = new Color(1,1,1);
        }
       
    }
}
