using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public float debounce = 2.0f;
    public float angle = 45.0f;
    float buttonpress = 0.0f;

    void Update()
    {
        if(Input.GetButton("XRI_Right_Primary2DAxisClick") && (buttonpress + debounce < Time.time))
        {
            float axis = Input.GetAxis("XRI_Right_Primary2DAxis_Horizontal");
            if(axis < 0.0f)
            {
                transform.Rotate(transform.up, angle);
            }
            else
            {
                transform.Rotate(transform.up, -angle);
            }

            buttonpress = Time.time;
        }
    }
}
