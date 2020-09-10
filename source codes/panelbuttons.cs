using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelbuttons : MonoBehaviour
{

public GameObject PausePanel, PauseButton, QuitButton;

    public void Pause(){
        PausePanel.SetActive(true);
        PauseButton.SetActive(false);
    }

 public void Resume(){
     PausePanel.SetActive(false);
     PauseButton.SetActive(true);
     
    }
public void Quitbutton(){
        Debug.Log ("Quit Game..");
        Application.Quit();

}
}
    