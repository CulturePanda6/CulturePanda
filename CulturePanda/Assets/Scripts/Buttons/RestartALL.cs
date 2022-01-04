using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartALL : MonoBehaviour
{
    public void RestartAll ()
    {
        SceneManager.LoadScene(0);
    }
}
