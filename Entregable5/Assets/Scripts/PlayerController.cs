using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 10.0f;
    private float turnSpeed = 100;
    private float verticalInput;
    private float horizontalInput;
    private Vector3 initialPos = Vector3.zero;
    private float endGame = 450f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = initialPos;
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // Movimiento hacia adelante
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // Rotación
        transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime * verticalInput);

        if (transform.position.z > endGame)
        {
            Debug.Log(message: "THE END");
            Time.timeScale = 0;
        }
    }
}
