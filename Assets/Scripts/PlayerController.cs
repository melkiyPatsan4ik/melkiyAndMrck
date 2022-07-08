using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       //  float forwardInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        // transform.Translate(Vector3.up * Time.deltaTime * 15);
        playerRb.AddRelativeForce(Vector3.up * 70);
        transform.Rotate(Vector3.forward * horizontalInput * Time.deltaTime * 500);
    }
}
