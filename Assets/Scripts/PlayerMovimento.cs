using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimento : MonoBehaviour
{
    Rigidbody2D rigidbody2D_;
    public int speed;
    public Animator animator;
    //public SpawnarGhost spawnarGhost_ref;

    void Awake()
    {
        animator = GetComponent<Animator>();
        rigidbody2D_ = GetComponent<Rigidbody2D>();
        //spawnarGhost_ref = GetComponent<SpawnarGhost>();
    }
    private void FixedUpdate()
    {

        Vector2 Position = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rigidbody2D_.velocity = Position * speed;



        if (Input.GetKey(KeyCode.RightArrow))
        {
            speed = 10;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            speed = 6;
        }

        if (Position.x > 0 || Position.x < 0 || Position.y > 0 || Position.y < 0)
        {
            animator.SetBool("Walking", true);
        }
        else
        {
            animator.SetBool("Walking", false);
        }


    }
}
