using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public ControlCursor controlCursor;
    public Text displayText;
    public Text textforGrab;
    public string description;
    public string grabText;
    public bool canGrab; // can add this to the inventory
    public bool shouldClear; // if you grab it, should dissapear from map 
    Animator animator;

    void OnMouseOver()
    {
        controlCursor.CambiarCursor("mano");
        animator = gameObject.GetComponent<Animator>();
        
        if (Input.GetMouseButtonDown(0)) {
            animator.SetBool("Activo", true);
            displayText.text = description;
            if (canGrab)
            {
                // yield return new WaitForSeconds(2);
                textforGrab.text = grabText;
                //canGrab = false;
                AddtoInventory();
                if (shouldClear)
                {
                    removeItem();
                }
            }
            //yield return new WaitForSeconds(4);
            //grabText = '';
        }

        if(Input.GetMouseButtonUp(0)) {
            if(animator.GetInteger("Repeticion") == 1) {
                animator.SetBool("Activo", false);
            }
        }
    }

    void AddtoInventory()
    {
        Debug.Log("added to inventory");
    }

    void removeItem()
    {
        Debug.Log("me borre la wea");
        Destroy(this);
    }

    void OnMouseExit()
    {
        controlCursor.CambiarCursor("normal");
    }
}
