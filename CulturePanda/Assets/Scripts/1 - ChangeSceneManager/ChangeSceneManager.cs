using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneManager : MonoBehaviour{
    public Animator transition;
    public void ChangeScene(string Scene){
        StartCoroutine(Load(Scene));
    }

    IEnumerator Load(string Scene){
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(Scene);
    }
}
