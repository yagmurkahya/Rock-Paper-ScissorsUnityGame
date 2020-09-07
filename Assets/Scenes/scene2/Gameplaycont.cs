using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum GameChoices{
    NONE,
    ROCK,
    PAPER,
    SCISSORS
}
public class Gameplaycont : MonoBehaviour
{
  [SerializeField]
  private Sprite rock_Sprite, paper_Sprite , scissors_Sprite;

  [SerializeField]
  private Image playerChoice_Img, rakipChoice_Img;

  [SerializeField]
  private Text infoText;
  private GameChoices player_Choice=GameChoices.NONE, rakipChoice=GameChoices.NONE;
  private animationController AnimationController;

  void Awake(){
      AnimationController=GetComponent<animationController>();
  }
public void SetChoices(GameChoices gameChoices){ 

switch (gameChoices){

    case GameChoices.ROCK:
    playerChoice_Img.sprite=rock_Sprite;
    player_Choice=GameChoices.ROCK;
    break;

    case GameChoices.PAPER:
    playerChoice_Img.sprite=paper_Sprite;
    player_Choice=GameChoices.PAPER;
    break;


case GameChoices.SCISSORS:
playerChoice_Img.sprite=scissors_Sprite;
    player_Choice=GameChoices.SCISSORS;
    break;
}


{
 SetrakipChoice();

DetermineWinner();
    
    void SetrakipChoice(){  
        int rnd=Random.Range(0,3);
        switch (rnd)
        {
            
            case 0:
            rakipChoice=GameChoices.ROCK;
            rakipChoice_Img.sprite=rock_Sprite;
            break;

            case 1:
            rakipChoice=GameChoices.PAPER;
            rakipChoice_Img.sprite=paper_Sprite;
            break;

            case 2:
            rakipChoice=GameChoices.SCISSORS;
            rakipChoice_Img.sprite=scissors_Sprite;
            break;
        }
      }
    void DetermineWinner(){

        if(player_Choice==rakipChoice){

            infoText.text="It's a draw!";

            StartCoroutine(DisplayWinnerAndRestrat());
            return;

        }
        if(player_Choice==GameChoices.PAPER && rakipChoice== GameChoices.ROCK){
            //player won

            infoText.text="You Win!";

            StartCoroutine(DisplayWinnerAndRestrat());
            return;


        }
        if(rakipChoice==GameChoices.PAPER && player_Choice== GameChoices.ROCK){
            //rakip won

            infoText.text="You Lose!";

            StartCoroutine(DisplayWinnerAndRestrat());
            return;

        }
        if(player_Choice==GameChoices.ROCK && rakipChoice== GameChoices.SCISSORS){
            //player won

            infoText.text="You Win!";

            StartCoroutine(DisplayWinnerAndRestrat());
            return;

        }
        if(rakipChoice==GameChoices.ROCK && player_Choice== GameChoices.SCISSORS){
            //rakip won

            infoText.text="You Lose!";

            StartCoroutine(DisplayWinnerAndRestrat());
            return;

        }
        if(player_Choice==GameChoices.SCISSORS && rakipChoice== GameChoices.PAPER){
            //player won

            infoText.text="You Win!";

            StartCoroutine(DisplayWinnerAndRestrat());
            return;

        }
        if(rakipChoice==GameChoices.SCISSORS && player_Choice== GameChoices.PAPER){
            //rakip won

            infoText.text="You Lose!";

            StartCoroutine(DisplayWinnerAndRestrat());
            return;

        }

    }

    IEnumerator DisplayWinnerAndRestrat()
    {
        yield return new WaitForSeconds(2f);
        infoText.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        infoText.gameObject.SetActive(false);
        AnimationController.ResetAnimations();
    }
}


}
}
