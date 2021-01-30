using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sillon : MonoBehaviour
{
    
    public ControlCursor controlCursor;
    Animator animator;

    void OnMouseOver() {
        controlCursor.CambiarCursor("mano");
        if(Input.GetMouseButtonDown(0)) {
            animator = gameObject.GetComponent<Animator>();
            animator.SetBool("Activo", true);
        }
    }

    void OnMouseExit() {
        controlCursor.CambiarCursor("normal");
    }

}
