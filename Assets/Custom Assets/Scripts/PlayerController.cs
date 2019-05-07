using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class PlayerController : MonoBehaviour
{
    SerialPort sp = new SerialPort("COM3", 9600);
    
    // Public
    [Header("Speed Components")]
    public float rotationSpeed = 10f;
    public float SensorSpeed = 0f;
    public float cycleSpeed = 0f;

    [Header("Animator")]
    public Animator frontWheel;
    public Animator frontTire;

    [Header("Gameobjects")]
    public GameObject frontWheelGO;

    [Header("Canvas")]
    public GameObject canvas;

    // Private
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sp.Open ();
        sp.ReadTimeout = 5;
    }

    void Update()
    {

        //float horizontal = Input.GetAxis("Horizontal");

        //Vector3 movement = new Vector3(0, 0, moveDir * cycleSpeed * Time.deltaTime);

        // The movement direction and cycleSpeed
        /*Vector3 movement = */transform.position += transform.forward * Time.deltaTime * cycleSpeed;

        //rb.MovePosition(transform.position + movement);

         try{
        //print (sp.ReadLine());
        string value = sp.ReadLine();
        SensorSpeed = float.Parse(value);
        cycleSpeed = SensorSpeed / 15 ;

        print (cycleSpeed);

        }
         catch(System.Exception){
        }

        if (cycleSpeed > 0f) 
        {
            canvas.SetActive(false);
        }

        // Check if the bycicle speed is not '0'
        if (cycleSpeed > 0) 
        {
            frontWheelGO.transform.Rotate(50, 0, 0 * Time.deltaTime);

        if (Input.GetButton("Right"))
            {
                transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
                frontWheel.SetBool("turningRight", true);
            }
            else
            {
                frontWheel.SetBool("turningRight", false);
            }


        if (Input.GetButton("Left"))
            {
                transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);
                frontWheel.SetBool("turningLeft", true);
            }
            else
            {
                frontWheel.SetBool("turningLeft", false);
            }
        }
        else
        {
            frontWheelGO.transform.Rotate(0, 0, 0 * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.O))
            cycleSpeed += 1f;

        if (cycleSpeed > 0) 
        {
            if (Input.GetKeyDown(KeyCode.P))
                cycleSpeed -= 1f;
        }
    }
}
