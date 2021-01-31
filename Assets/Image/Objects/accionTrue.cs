using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class accionTrue : MonoBehaviour {

    Animator animator;

    public void Update() {
        animator = gameObject.GetComponent<Animator>();
        animator.SetBool("Activo", true);
        
    }

    
}
