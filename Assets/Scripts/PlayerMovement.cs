using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;

    float rotation;

    public float runSpeed = 20.0f;

    GameObject joystick;

    void Start ()
    {
        body = GetComponent<Rigidbody2D>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.lockState = CursorLockMode.Confined;
        //joystick = GameObject.FindGameObjectWithTag("GameController");
        //Application.targetFrameRate = 1000;
        print(GameObject.Find("special").layer);
    }

    void Update ()
    {
        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        
        // horizontal = joystick.GetComponent<VariableJoystick>().Direction.x;
        // vertical = joystick.GetComponent<VariableJoystick>().Direction.y;

        if(Input.GetKeyDown(KeyCode.Escape)) {
            #if UNITY_EDITOR
                // Application.Quit() does not work in the editor so
                // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }

        body.velocity = (transform.up * (vertical * runSpeed)) + (transform.right * (horizontal * runSpeed));

        rotation = Input.GetAxisRaw("Mouse X");
        //rotation = 0;
        transform.Rotate(new Vector3(0,0,rotation * 10f * -1f));
        //print(rotation);
    }

    private void FixedUpdate()
    {  
        Vector3 forward = transform.forward * vertical;
        Vector3 right = transform.forward * horizontal;

        

        //body.velocity = new Vector2((horizontal * runSpeed), vertical * runSpeed);
        //print(transform.rotation.z * 90);
       // transform.Rotate(new Vector3(0,0,rotation * 10f));
    }
}
