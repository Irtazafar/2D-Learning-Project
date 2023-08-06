using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappBird : MonoBehaviour
{

    public float velocity;
    public Rigidbody2D birdRigidBody;

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetKeyDown(KeyCode.Space))
        {
            birdRigidBody.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided");
    }
}
