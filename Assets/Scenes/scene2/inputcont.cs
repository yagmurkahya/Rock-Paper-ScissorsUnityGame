using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputcont : MonoBehaviour
{
    private animationController AnimationController;

    private Gameplaycont gamePlaycont;

    private string playersChoice;

    void Awake(){

        AnimationController= GetComponent<animationController>();
        gamePlaycont = GetComponent<Gameplaycont>();
    }
  
    public void GetChoice() {

        string choiceName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        

        GameChoices selectedChoice = GameChoices.NONE;

        switch (choiceName)
        {
            case "Rock":
            selectedChoice= GameChoices.ROCK;
                 break;

            case "Paper":
            selectedChoice= GameChoices.PAPER;
                 break;

            case "Scissors":
            selectedChoice= GameChoices.SCISSORS;
                 break;
            
        }
        gamePlaycont.SetChoices(selectedChoice);
        AnimationController.PlayerMadeChoice();
    }
}
