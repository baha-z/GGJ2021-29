using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public ControlCursor controlCursor;
    public Text displayText;
    public string description;
    Animator animator;

    void OnMouseOver()
    {
        controlCursor.CambiarCursor("mano");
        animator = gameObject.GetComponent<Animator>();
        
        if (Input.GetMouseButtonDown(0)) {
            animator.SetBool("Activo", true);
            displayText.text = description;
        }

        if(Input.GetMouseButtonUp(0)) {
            if(animator.GetInteger("Repeticion") == 1) {
                animator.SetBool("Activo", false);
            }
        }
    }

    void OnMouseExit()
    {
        controlCursor.CambiarCursor("normal");
    }
}
