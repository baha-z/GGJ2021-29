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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        controlCursor.CambiarCursor("mano");
        if (Input.GetMouseButtonDown(0))
        {
            animator = gameObject.GetComponent<Animator>();
            animator.SetBool("Activo", true);
            displayText.text = description;
        }
    }

    void OnMouseExit()
    {
        controlCursor.CambiarCursor("normal");
    }
}
