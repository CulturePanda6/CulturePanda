using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuManager : MonoBehaviour{
    private Transform music, changeScene, MB, MBC;
    
    void Start(){
        music = gameObject.transform.root.Find("/Background Music");
        MB = transform.Find("Options/Music Buttons/Music Button");
        MBC = transform.Find("Options/Music Buttons/Music Button Checked");
        if(music.GetComponent<AudioManager>().isPlaying()) MBC.gameObject.SetActive(true);
        else MB.gameObject.SetActive(true);

        Screen.SetResolution(1920, 1080, Screen.fullScreen);
    }

    public void PlayMenu(){
        changeScene = gameObject.transform.root.Find("/Crossfade");
        changeScene.GetComponent<ChangeSceneManager>().ChangeScene("Map");
    }

    public void OptionsMenu(int opt){
        if(opt == 1){ //Goes to Options Menu
            Transform Main = transform.Find("Main"), Options = transform.Find("Options");
            Main.gameObject.SetActive(false);
            Options.gameObject.SetActive(true);
        }else if(opt == 2){ //Backs to the Main Menu
            Transform Main = transform.Find("Main"), Options = transform.Find("Options");
            Main.gameObject.SetActive(true);
            Options.gameObject.SetActive(false);
        }else if(opt == 3){ //Fullscreen mode
            Transform FB = transform.Find("Options/Fullscreen Buttons/Fullscreen Button"), FBC = transform.Find("Options/Fullscreen Buttons/Fullscreen Button Checked");
            if(FBC.gameObject.activeSelf){
                Screen.fullScreen = false;
                FBC.gameObject.SetActive(false);
                FB.gameObject.SetActive(true);
            }else{
                Screen.fullScreen = true;
                FBC.gameObject.SetActive(true);
                FB.gameObject.SetActive(false);
            }
        }else if(opt == 4){ //Resolution
            Transform style = transform.Find("Options/Resolution Buttons/Style Drop Menu"), HDDrop = transform.Find("Options/Resolution Buttons/1024x768 Drop Button"),
                FHDDrop = transform.Find("Options/Resolution Buttons/1920x1080 Drop Button"), DKDrop = transform.Find("Options/Resolution Buttons/2080x1080 Drop Button"),
                HDClick = transform.Find("Options/Resolution Buttons/1024x768 Click"), FHDClick = transform.Find("Options/Resolution Buttons/1920x1080 Click"),
                DKClick = transform.Find("Options/Resolution Buttons/2048x1080 Click");

            bool tof;
            if(style.gameObject.activeSelf) tof = false;
            else tof = true;
            style.gameObject.SetActive(tof);
            HDDrop.gameObject.SetActive(tof);
            FHDDrop.gameObject.SetActive(tof);
            DKDrop.gameObject.SetActive(tof);
            HDClick.gameObject.SetActive(tof);
            FHDClick.gameObject.SetActive(tof);
            DKClick.gameObject.SetActive(tof);
        }else if(opt == 5){ //Graphics
            Transform style = transform.Find("Options/Graphics Buttons/Style Drop Menu"), lowDrop = transform.Find("Options/Graphics Buttons/Low Drop Button"),
                mediumDrop = transform.Find("Options/Graphics Buttons/Medium Drop Button"), highDrop = transform.Find("Options/Graphics Buttons/High Drop Button"),
                HDClick = transform.Find("Options/Graphics Buttons/Low Click"), FHDClick = transform.Find("Options/Graphics Buttons/Medium Click"),
                DKClick = transform.Find("Options/Graphics Buttons/High Click");

            bool tof;
            if(style.gameObject.activeSelf) tof = false;
            else tof = true;
            style.gameObject.SetActive(tof);
            lowDrop.gameObject.SetActive(tof);
            mediumDrop.gameObject.SetActive(tof);
            highDrop.gameObject.SetActive(tof);
            HDClick.gameObject.SetActive(tof);
            FHDClick.gameObject.SetActive(tof);
            DKClick.gameObject.SetActive(tof);
        }else if(opt == 6){ //Music
            if(MBC.gameObject.activeSelf){
                MBC.gameObject.SetActive(false);
                MB.gameObject.SetActive(true);
                music.GetComponent<AudioManager>().StopMusic();
            }else{
                MBC.gameObject.SetActive(true);
                MB.gameObject.SetActive(false);
                music.GetComponent<AudioManager>().PlayMusic();
            }
        }
    }

    public void DropOptionResolution(int drop){
        Transform style = transform.Find("Options/Resolution Buttons/Style Drop Menu"), HDDrop = transform.Find("Options/Resolution Buttons/1024x768 Drop Button"),
                FHDDrop = transform.Find("Options/Resolution Buttons/1920x1080 Drop Button"), DKDrop = transform.Find("Options/Resolution Buttons/2080x1080 Drop Button"),
                HDButton = transform.Find("Options/Resolution Buttons/1024x768 Button"), FHDButton = transform.Find("Options/Resolution Buttons/1920x1080 Button"),
                DKButton = transform.Find("Options/Resolution Buttons/2048x1080 Button"), HDClick = transform.Find("Options/Resolution Buttons/1024x768 Click"),
                FHDClick = transform.Find("Options/Resolution Buttons/1920x1080 Click"), DKClick = transform.Find("Options/Resolution Buttons/2048x1080 Click");
        
        if(drop == 1){ //1024x768
            Screen.SetResolution(1024, 768, Screen.fullScreen);
            HDButton.gameObject.SetActive(true);
            FHDButton.gameObject.SetActive(false);
            DKButton.gameObject.SetActive(false);
        }else if(drop == 2){ //1920x1080
            Screen.SetResolution(1920, 1080, Screen.fullScreen);
            HDButton.gameObject.SetActive(false);
            FHDButton.gameObject.SetActive(true);
            DKButton.gameObject.SetActive(false);
        }else if(drop == 3){ //2048x1080
            Screen.SetResolution(2048, 1080, Screen.fullScreen);
            HDButton.gameObject.SetActive(false);
            FHDButton.gameObject.SetActive(false);
            DKButton.gameObject.SetActive(true);
        }

        style.gameObject.SetActive(false);
        HDDrop.gameObject.SetActive(false);
        FHDDrop.gameObject.SetActive(false);
        DKDrop.gameObject.SetActive(false);
        HDClick.gameObject.SetActive(false);
        FHDClick.gameObject.SetActive(false);
        DKClick.gameObject.SetActive(false);
    }

    public void DropOptionGraphics(int drop){
        Transform style = transform.Find("Options/Graphics Buttons/Style Drop Menu"), lowDrop = transform.Find("Options/Graphics Buttons/Low Drop Button"),
                mediumDrop = transform.Find("Options/Graphics Buttons/Medium Drop Button"), highDrop = transform.Find("Options/Graphics Buttons/High Drop Button"),
                lowButton = transform.Find("Options/Graphics Buttons/Low Button"), mediumButton = transform.Find("Options/Graphics Buttons/Medium Button"),
                highButton = transform.Find("Options/Graphics Buttons/High Button"), lowClick = transform.Find("Options/Graphics Buttons/Low Click"),
                mediumClick = transform.Find("Options/Graphics Buttons/Medium Click"), highClick = transform.Find("Options/Graphics Buttons/High Click");
        
        if(drop == 1){ //Low
            QualitySettings.SetQualityLevel(0);
            lowButton.gameObject.SetActive(true);
            mediumButton.gameObject.SetActive(false);
            highButton.gameObject.SetActive(false);
        }else if(drop == 2){ //Medium
            QualitySettings.SetQualityLevel(1);
            lowButton.gameObject.SetActive(false);
            mediumButton.gameObject.SetActive(true);
            highButton.gameObject.SetActive(false);
        }else if(drop == 3){ //High
            QualitySettings.SetQualityLevel(2);
            lowButton.gameObject.SetActive(false);
            mediumButton.gameObject.SetActive(false);
            highButton.gameObject.SetActive(true);
        }

        style.gameObject.SetActive(false);
        lowDrop.gameObject.SetActive(false);
        mediumDrop.gameObject.SetActive(false);
        highDrop.gameObject.SetActive(false);
        lowClick.gameObject.SetActive(false);
        mediumClick.gameObject.SetActive(false);
        highClick.gameObject.SetActive(false);
    }

    public void ExitMenu(int opt){
        if(opt == 1){ //Goes to Exit Menu
            Transform Main = transform.Find("Main"), Exit = transform.Find("Exit");
            Main.gameObject.SetActive(false);
            Exit.gameObject.SetActive(true);
        }else if(opt == 2){ //Cancels and goes to main Menu
            Transform Main = transform.Find("Main"), Exit = transform.Find("Exit");
            Main.gameObject.SetActive(true);
            Exit.gameObject.SetActive(false);
        }else if(opt == 3){ //Exits the game
            Application.Quit();
        }
    }
}
