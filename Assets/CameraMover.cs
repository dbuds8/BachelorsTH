using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    // Start is called before the first frame update
    public float pixelsToMove = 2000f;

    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    public void MoveCameraAlongX(float pixels)
    {
        Debug.Log("Camera script entered");
        

        Vector3 newPosition = cam.gameObject.transform.position;
        Debug.Log("Original position is " + cam.gameObject.transform.position);
        newPosition.x += pixels;

        cam.gameObject.transform.position = newPosition;
        Debug.Log("New position is " + cam.gameObject.transform.position);

    }

    public void MoveCameraAlongY(float pixels)
    {
        Debug.Log("Camera script entered");


        Vector3 newPosition = cam.gameObject.transform.position;
        Debug.Log("Original position is " + cam.gameObject.transform.position);
        newPosition.y += pixels;

        cam.gameObject.transform.position = newPosition;
        Debug.Log("New position is " + cam.gameObject.transform.position);

    }


}
