using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    float horizontalInput;
    
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        float movement = horizontalInput * moveSpeed * Time.deltaTime;

        transform.position += new Vector3(movement, 0, 0);

        float limitMovement = GameManager.Instance.gameWidth / 2;

        if(transform.position.x < -limitMovement)
        {
            transform.position = new Vector3(-limitMovement,transform.position.y,transform.position.z);
        } 
        else if(transform.position.x > limitMovement)
        {
            transform.position = new Vector3(limitMovement,transform.position.y,transform.position.z);
        }
        
     
    }

}
