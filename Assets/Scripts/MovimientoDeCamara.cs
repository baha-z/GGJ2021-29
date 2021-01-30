using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDeCamara : MonoBehaviour
{

    public Vector2 minCamPos, maxCamPos;
    float posX = 0;
    float posY = 1;

    void FixedUpdate()
    {

        if(Input.GetKey(KeyCode.W)) {
            if(maxCamPos.y > posY) {
                posY += 0.2f;
            }
        }

        if(Input.GetKey(KeyCode.A)) {
            if(minCamPos.x < posX) {
                posX -= 0.2f;
            }
        }

        if(Input.GetKey(KeyCode.S)) {
            if(minCamPos.y < posY) {
                posY -= 0.2f;
            }
        }

        if(Input.GetKey(KeyCode.D)) {
            if(maxCamPos.x > posX) {
                posX += 0.2f;
            }
        }

        transform.position = new Vector3(
            Mathf.Clamp(posX, minCamPos.x, maxCamPos.x),
            Mathf.Clamp(posY, minCamPos.y, maxCamPos.y),
            -10
        );
    }
}
