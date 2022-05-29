using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRaycasting : MonoBehaviour
{
    // hit variable to store our results
    RaycastHit hit;

    Ray ray;

    private void FixedUpdate()
    {
        
        // check for mouse input first
        if (Input.GetMouseButtonDown(0))
        {
            // a ray that goes from screen coordinates forward into our world
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // coundct our Raycast
            if (Physics.Raycast(ray, out hit))
            {

                hit.collider.gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.yellow);

            }
            else
            {
                Debug.Log("We didn't hit anything.");
            }

        }
                     
        
    }
}
