using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public Animator animator;
    public float movementSpeed;
    public Rigidbody2D rb;
    float movementX;

    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update() {
        movementX = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(movementX));
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            sr.flipX = true;
        }
    }

    private void FixedUpdate() {
        Vector2 movement = new Vector2(movementX * movementSpeed, rb.velocity.y);

        rb.velocity = movement;
    }
}
