using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    public float moveSpeed = 10;



    void Update()
    {

        if (Input.GetKey(KeyCode.W) & Input.GetKey(KeyCode.A)){
            transform.position += (Vector3.up * moveSpeed * Time.deltaTime / 2) + (Vector3.right * -moveSpeed * Time.deltaTime / 2);
        }

        else if (Input.GetKey(KeyCode.W) & Input.GetKey(KeyCode.D))
        {
            transform.position += (Vector3.up * moveSpeed * Time.deltaTime / 2) + (Vector3.right * moveSpeed * Time.deltaTime / 2);
        }

        else if (Input.GetKey(KeyCode.S) & Input.GetKey(KeyCode.A))
        {
            transform.position += (Vector3.up * -moveSpeed * Time.deltaTime / 2) + (Vector3.right * -moveSpeed * Time.deltaTime / 2);
        }

        else if (Input.GetKey(KeyCode.S) & Input.GetKey(KeyCode.D))
        {
            transform.position += (Vector3.up * -moveSpeed * Time.deltaTime / 2) + (Vector3.right * moveSpeed * Time.deltaTime / 2);
        }

        else if (Input.GetKey(KeyCode.W)) {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;

        }
        
        else if (Input.GetKey(KeyCode.A)) {
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;

        }
        
        else if (Input.GetKey(KeyCode.D)){
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;

        }
        
        else if (Input.GetKey(KeyCode.S)){
            transform.position += Vector3.up * -moveSpeed * Time.deltaTime;

        }
        
    }
        
    
}
