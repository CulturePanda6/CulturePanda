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
        // all buttons painted with the same color for 
        // the only one button could be grey
        for (int i = 0; i < _functionsButtons.Length; i++) 
        {
            _functionsButtons[i].GetComponent<Image>().color = new Color(1,1,1);
        }
       
    }
}
