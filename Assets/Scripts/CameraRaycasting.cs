using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRaycasting : MonoBehaviour
{
    private void FixedUpdate()
    {
        // hit variable to store our results
        RaycastHit hit;

        // a ray that goes from screen coordinates forward into our world
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

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
