using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManControllerFM : MonoBehaviour
{
    public float speed = 5.0f;
    private Vector2 direction = Vector2.zero;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        HandleInput();
        Move();
        UpdateAnimation();
    }

    void HandleInput()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            direction = Vector2.up;
        else if (Input.GetKey(KeyCode.DownArrow))
            direction = Vector2.down;
        else if (Input.GetKey(KeyCode.LeftArrow))
            direction = Vector2.left;
        else if (Input.GetKey(KeyCode.RightArrow))
            direction = Vector2.right;
    }

    void Move()
    {
        Vector2 pos = transform.position;
        pos += direction * speed * Time.deltaTime;
        transform.position = pos;
    }

    void UpdateAnimation()
    {
        if (direction == Vector2.right)
        {
            animator.SetBool("isMovingRight", true);
            animator.SetBool("isMovingLeft", false);
        }
        else if (direction == Vector2.left)
        {
            animator.SetBool("isMovingRight", false);
            animator.SetBool("isMovingLeft", true);
        }
        else
        {
            animator.SetBool("isMovingRight", false);
            animator.SetBool("isMovingLeft", false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall"))
        {
            // Handle collision with wall
            direction = Vector2.zero;
        }
        else if (other.CompareTag("Point"))
        {
            // Handle collecting a point
            GameManagerFM.instance.AddPoint();
            Destroy(other.gameObject);
        }
    }
}
