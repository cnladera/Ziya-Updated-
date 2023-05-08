using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float yForce;
    public float XForce;
    public float xDirection;

    private Rigidbody2D enemyRigidBody;

        void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(XForce * xDirection, yForce);
            enemyRigidBody.AddForce(jumpForce);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            Vector2 jumpForce = new Vector2(XForce * xDirection, yForce);
            enemyRigidBody.AddForce(jumpForce);
        }
        if (collision.gameObject.tag == "Player")
        {
            Vector2 jumpForce = new Vector2(XForce * xDirection, yForce);
            enemyRigidBody.AddForce(jumpForce);
        }
    }

    private void FixedUpdate()
    {
        if(transform.position.x <= -8)
        {
            xDirection = 1;
            enemyRigidBody.AddForce(Vector2.right * XForce);
        }
        if(transform.position.x >= 8)
        {
            xDirection = -1;
            enemyRigidBody.AddForce(Vector2.left * XForce);
        }
        if (transform.position.y >= 4)
        {
            xDirection = 1;
            enemyRigidBody.AddForce(Vector2.down * yForce);
        }


            /*
            float newXPosition = transform.position.x + speed * Time.deltaTime;
            float newYPosition = transform.position.y;
            Vector2 newPosition = new Vector2(newXPosition, newYPosition);
            transform.position = newPosition;
            */
        }
}
