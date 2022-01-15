using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PandaMove : MonoBehaviour
{
    public int BambooInThisLevel;
    private ButtonController _buttonController;
    public int i;
    public GameObject YouAreLostPanel;
    public bool Endf0;
    public GameObject[] Purple;
    public GameObject[] Pink;
    public GameObject[] Yellow;
    private bool ValikActive;
    public GameObject CurrentCube;
    public Material PurpleMaterial;
    public Material PinkMaterial;
    public Material YellowMaterial;
    private Material CountMaterial;
    private string CurrentTag;
    [SerializeField]private int _findedBamboo;

    // Start is called before the first frame update
    void Start()
    {
        // for the cause to the 0 elements for the first time
        i = 0;

        //just to call another script
        _buttonController = FindObjectOfType<ButtonController>();

        // just in case turn off the lost panel
        YouAreLostPanel.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        
        if(BambooInThisLevel == _findedBamboo)
        {
            SceneManager.LoadScene("Map");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        // repeat animations for infinite repeating the answer if "f0" is set
        if (Endf0 == true && i >= _buttonController.StringForAnimation.Length) 
        {
            i = 0;
        }
    }

  
    public void OnAnimationEnded()  
    {
        if (i < _buttonController.StringForAnimation.Length)
        {
            CheckingCubes();
        }

        // repeat animations for infinite repeating the answer
        else if (Endf0 == false) 
        {
            // turn on the lost panel
            YouAreLostPanel.SetActive(true);
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wrong"))
        {
            // turn on the lost panel
            YouAreLostPanel.SetActive(true);
        }

        if (other.CompareTag("Finish"))
        {
            SceneManager.LoadScene("Map");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }

        if(other.CompareTag("Bamboo"))
        {
            Destroy(other.gameObject);
            _findedBamboo++;

        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PurpleCube"))
        {
            for (int e = 0; e < Purple.Length; e++)
            {
                Purple[e].SetActive(true);
            }
        }

        if (other.CompareTag("PinkCube"))
        {
            for (int e = 0; e < Pink.Length; e++)
            {
                Pink[e].SetActive(true);
            }
        }

        if (other.CompareTag("YellowCube"))
        {
            for (int e = 0; e < Yellow.Length; e++)
            {
                Yellow[e].SetActive(true);
            }

        }
    }

    private void OnTriggerStay(Collider other)
    {
         if (other.CompareTag("PurpleCube"))
        {
            for(int e= 0; e < Purple.Length; e++)
            {
                Purple[e].SetActive(false);
            }
            if(ValikActive == true)
            {
                CurrentCube = other.gameObject;
                CurrentCube.GetComponent<Renderer>().material = CountMaterial;
                CurrentCube.tag = CurrentTag;
                ValikActive = false;
                for (int e = 0; e < Purple.Length; e++)
                {
                    Purple[e].SetActive(true);
                }
                OnAnimationEnded();
            }
        }

        if (other.CompareTag("PinkCube"))
        {
            for (int e = 0; e < Pink.Length; e++)
            {
                Pink[e].SetActive(false);
            }
            if (ValikActive == true)
            {
                CurrentCube = other.gameObject;
                CurrentCube.GetComponent<Renderer>().material = CountMaterial;
                CurrentCube.tag = CurrentTag;
                ValikActive = false;
                for (int e = 0; e < Pink.Length; e++)
                {
                    Pink[e].SetActive(true);
                }
                OnAnimationEnded();
            }
        }

        if (other.CompareTag("YellowCube"))
        {
            for (int e = 0; e < Yellow.Length; e++)
            {
                Yellow[e].SetActive(false);
            }
            if (ValikActive == true)
            {
                CurrentCube = other.gameObject;
                CurrentCube.GetComponent<Renderer>().material = CountMaterial;
                CurrentCube.tag = CurrentTag;
                ValikActive = false;
                for (int e = 0; e < Yellow.Length; e++)
                {
                    Yellow[e].SetActive(true);
                }
                OnAnimationEnded    ();
            }
        }

    }

    public void OkButton()
    {
        Purple = GameObject.FindGameObjectsWithTag("Purple");
        Pink = GameObject.FindGameObjectsWithTag("Pink");
        Yellow = GameObject.FindGameObjectsWithTag("Yellow");
        OnAnimationEnded();
    }

    void Valik()
    {
        if (_buttonController.StringForAnimation[i] == "PurpleValik")
        {
            CountMaterial = PurpleMaterial;
            CurrentTag = "PurpleCube";
            ValikActive = true;
        }

        if (_buttonController.StringForAnimation[i] == "PinkValik")
        {
            CountMaterial = PinkMaterial;
            CurrentTag = "PinkCube";
            ValikActive = true;
        }

        if (_buttonController.StringForAnimation[i] == "YellowValik")
        {
            CountMaterial = YellowMaterial;
            CurrentTag = "YellowCube";
            ValikActive = true;
        }

    }

    void CheckingCubes()
    {
        for (int e = i; e < _buttonController._colorsInsideFunctionButtons.Length; e++)
        {

            if (_buttonController._colorsInsideFunctionButtons[e].activeInHierarchy == false)
            {
                i = e;
                if (_buttonController.StringForAnimation[i] == "PurpleValik" || _buttonController.StringForAnimation[i] == 
                    "PinkValik" || _buttonController.StringForAnimation[i] == "YellowValik")
                {
                    Valik();
                    i++;
                    break;
                }

                if(_buttonController._colorsInsideFunctionButtons[e].activeInHierarchy == false)
                {
                    this.GetComponent<Animator>().SetTrigger(_buttonController.StringForAnimation[i]);
                    i++;
                    break;
                }

            }

            else if (e == _buttonController._colorsInsideFunctionButtons.Length - 1)
            {
                i = 0;
                for (int f = i; f < _buttonController._colorsInsideFunctionButtons.Length; f++)
                {
                    if (_buttonController._colorsInsideFunctionButtons[f].activeInHierarchy == false)
                    {
                        i = f;
                        if (_buttonController.StringForAnimation[i] == "PurpleValik" || _buttonController.StringForAnimation[i] == "PinkValik" 
                            || _buttonController.StringForAnimation[i] == "YellowValik")
                        {
                            Valik();
                            i++;
                            break;
                        }

                        if (_buttonController._colorsInsideFunctionButtons[f].activeInHierarchy == false)
                        {
                            this.GetComponent<Animator>().SetTrigger(_buttonController.StringForAnimation[i]);
                            i++;
                            break;
                        }
                    }
                }
            }
        }
    }
}
