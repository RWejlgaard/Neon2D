using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineOfSight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 start = transform.position;
        Vector3 direction = new Vector3(0,1,0);
        float distance = 10;
        
        //draw the ray in the editor
        Debug.DrawRay(start,direction*distance, Color.red);
        
        //do the ray test
        RaycastHit2D sightTest = Physics2D.Raycast(start,  direction, distance);
        if (sightTest.collider != null) 
        {
            if (sightTest.collider.gameObject != gameObject) 
            {
                //finalDetected = null;
                Debug.Log ("Rigidbody collider is: " + sightTest.collider);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
