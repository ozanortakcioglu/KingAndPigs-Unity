using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpController : MonoBehaviour
{
    public Animator animator;
    public EndController endController;

    public void Down()
    {
        animator.SetTrigger("Down");
        endController.TheEnd();
    }
}
