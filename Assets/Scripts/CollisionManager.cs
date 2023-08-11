using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            GameManager.Instance.score++;
            Debug.Log("Score: " + GameManager.Instance.score);
            Destroy(other.gameObject);
        } 
    }
    
}
