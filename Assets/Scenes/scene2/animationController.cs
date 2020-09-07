using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    [SerializeField]
    private Animator PlayerchoiceAnimation , ChoiceAnimation;

    public void ResetAnimations(){
       PlayerchoiceAnimation.Play("showhand");
       ChoiceAnimation.Play("removechoices");

   }
   public void PlayerMadeChoice(){
       PlayerchoiceAnimation.Play("removehand");
       ChoiceAnimation.Play("showchoices");
   }
        
}

