using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour // Defines the Movement class which inherits from MonoBehaviour
{
    public float speed = 5.0f; // Creates a variable which will be used as the speed of our object's movement
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //  Gets the horizontal input (A/D keys or left/right arrow keys) and stores it in the variable.
        float moveVertical = Input.GetAxis("Vertical"); //  Gets the vertical input (W/S keys or up/down arrow keys) and stores it in the variable.

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); // Creates a Vector3 object representing the direction of movement. 

        transform.Translate(movement * speed * Time.deltaTime, Space.World); // Moves the object 

    }
}

