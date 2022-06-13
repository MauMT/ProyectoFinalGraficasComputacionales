using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementController : MonoBehaviour
{

    float speed = 50;

    // Rotates the camera using left and right arrows
    void Update()
    {
      
        if (Input.GetKey(KeyCode.LeftArrow)) { 
           transform.Rotate(0, speed * Time.deltaTime, 0);   
        }
        else if (Input.GetKey(KeyCode.RightArrow)){
            transform.Rotate(0, -speed * Time.deltaTime, 0);
        }
        
    }
}
