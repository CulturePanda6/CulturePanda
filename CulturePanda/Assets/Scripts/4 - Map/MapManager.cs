using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class MapManager : MonoBehaviour{
    private Transform music, changeScene, MB, MBC;
    public static int ChosenLevel = 1;
    void Start(){
        music = gameObject.transform.root.Find("/Background Music");
        MB = transform.Find("Menu Settings/Music Buttons/Music Button");
        MBC = transform.Find("Menu Settings/Music Buttons/Music Button Checked");
        if(music.GetComponent<AudioManager>().isPlaying()) MBC.gameObject.SetActive(true);
        else MB.gameObject.SetActive(true);
    }

    public void MenuOptions(int opt){
        if(opt == 1){
            Transform menu = transform.Find("Menu Settings");
            if(!menu.gameObject.activeSelf) menu.gameObject.SetActive(true);
            else menu.gameObject.SetActive(false);
        }else if(opt == 2){
            if(MBC.gameObject.activeSelf){
                MB.gameObject.SetActive(true);
                MBC.gameObject.SetActive(false);
                music.GetComponent<AudioManager>().StopMusic();
            }else{
                MB.gameObject.SetActive(false);
                MBC.gameObject.SetActive(true);
                music.GetComponent<AudioManager>().PlayMusic();
            }
        }else if(opt == 3){
            changeScene = gameObject.transform.root.Find("/Crossfade");
            changeScene.GetComponent<ChangeSceneManager>().ChangeScene("Menu");
        }
    }

    public void PlayOptions(int opt){
        Transform play = transform.Find("Play");
        if(opt == 1){
            play.gameObject.SetActive(false);
        }else if(opt == 2){
            changeScene = gameObject.transform.root.Find("/Crossfade");
            changeScene.GetComponent<ChangeSceneManager>().ChangeScene("Level" + ChosenLevel);
        }
    }

    public void Level(int lvl){
        ChosenLevel = lvl;
        Transform level = transform.Find("Play/Level"), difficulty = transform.Find("Play/Difficulty");
        level.GetComponent<TMPro.TextMeshProUGUI>().text = "Level: " + lvl;
        if(lvl < 5) difficulty.GetComponent<TMPro.TextMeshProUGUI>().text = "Difficulty: Easy";
        else if(lvl < 9) difficulty.GetComponent<TMPro.TextMeshProUGUI>().text = "Difficulty: Medium";
        else difficulty.GetComponent<TMPro.TextMeshProUGUI>().text = "Difficulty: Hard";

        Transform play = transform.Find("Play");
        play.gameObject.SetActive(true);
    }
}