using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
public float m_speed = 5;
CharacterController controller;
Vector3 currentMovement;

Rigidbody rb;

bool floorDetected = false; 
bool Isjump = false;
public float ForceJump = 5.0f;
void Start () 
    {        
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

void Update () 
    {
        float horizontal = Input.GetAxis ("Horizontal"); // A D alrededor
        float vertical = Input.GetAxis ("Vertical"); // W S arriba y abajo
 
        transform.Translate (Vector3.forward * vertical * m_speed * Time.deltaTime); // W S arriba y abajo
        transform.Translate (Vector3.right * horizontal * m_speed * Time.deltaTime); // A D alrededor


    Vector3 floor = transform.TransformDirection(Vector3.down);

    if(Physics.Raycast(transform.position, floor, 1.03f))
    {
        floorDetected = true;
        print("Contacto con el suelo");
        
    }
     else
    {
        floorDetected = false;
        print("No hay contacto");
    }

    Isjump = Input.GetButtonDown("Jump");

    if(Isjump && floorDetected)
    {   
        rb.AddForce(new Vector3(0,ForceJump,9), ForceMode.Impulse); 
    }

    }
}
