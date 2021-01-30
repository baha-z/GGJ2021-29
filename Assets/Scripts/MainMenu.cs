using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // public ControlCursor controlCursor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // public void OnPointerEnter(PointerEventData eventData) {
    //     controlCursor.CambiarCursor("mano");
    // }

    // public void OnPointerExit(PointerEventData eventData) {
    //     controlCursor.CambiarCursor("normal");
    // }

    public void CargarNivel(string nombreNivel){
        SceneManager.LoadScene(nombreNivel);
    }
}
