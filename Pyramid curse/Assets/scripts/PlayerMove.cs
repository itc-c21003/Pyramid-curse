using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMove : MonoBehaviour
{
    Vector3 moves; 
    CharacterController controller;
    public float speed; public float gr;
    private Vector3 lastMousePosition;
    float Ydiff; float Xdiff;
    bool on = false;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void LateUpdate()
    {
        var touchCount = Input.touchCount;

        controller.Move(moves * Time.deltaTime);
        moves = gameObject.transform.rotation * new Vector3(0, 0, speed);
        if (!controller.isGrounded) moves.y -= gr;
        else if (controller.isGrounded) moves.y = 0;
        if (Input.GetButtonDown("Vertical"))
        {
            transform.Rotate(new Vector3(0, -180, 0));
        }
        if (Input.GetMouseButtonDown(0))
        {
            lastMousePosition = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            Xdiff = Input.mousePosition.x - lastMousePosition.x;
            Ydiff = Input.mousePosition.y - lastMousePosition.y;
                if (Xdiff > 0 && touchCount <2)
                {
                    on = false;
                    transform.Rotate(new Vector3(0,180, 0) * Time.deltaTime);
                }
                if (Xdiff < 0 && touchCount < 2)
                {
                    on = false;
                    transform.Rotate(new Vector3(0, -180, 0) * Time.deltaTime);
                }
                if (Ydiff < 0 && touchCount >= 2)
                {
                    if(!on)
                    {
                        on = true;
                        transform.Rotate(new Vector3(0, -180, 0));
                    }
                }
        }
        if (Input.GetMouseButtonUp(0))
        {
            on = false;
        }
    }
}