using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AshamanScript : MonoBehaviour
{
    // public Rigidbody2D myRigidbody: Creates a reference to our RigidBody2D in unity. Our script now has a place to drag and drop our component
    public Rigidbody2D myRigidbody;
    public Transform myTransform;

    // I could say "speed == int;" but if i just delare a public float variable then inside of Unity there will be a new field
    // inside the script component where I can manually adjust the number.
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // GetKeyDown: It returns true only on the frame where the key is first pressed down.  Is used for detecting the initial press of a key
        // GetKey: It returns true as long as the specified key is being held down.  Is used for detecting if a key is being held down continuously
        if (Input.GetKey(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector2.up * 3;
        }
        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            myRigidbody.velocity = Vector2.right * speed;
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            myRigidbody.velocity = Vector2.down * speed;
        }
        if (Input.GetKeyDown(KeyCode.A) == true)
        {
            myRigidbody.velocity = Vector2.left * speed;
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            // This code is the same as the commented code under it.
            Vector2 diagonalDirection = new Vector2(1, 1).normalized;
            myRigidbody.velocity = diagonalDirection * speed;
            // myRigidbody.velocity = new Vector2(1, 1) * speed;
        }
        if (Input.GetKeyDown(KeyCode.G) == true)
        {
            myTransform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
