using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroWait : MonoBehaviour{
    public float waitTime = 9f;
    void Start(){
        StartCoroutine(Wait());
    }

    IEnumerator Wait(){
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("Menu");
    }
}