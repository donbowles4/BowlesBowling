using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] float fltRunSpd = 10f;
    [SerializeField] float fltJumpSpd = 10f;
    Vector2 movingInput;
    public Rigidbody2D myRB;
    CapsuleCollider2D playerBody;
    Animator guyAnimation;


    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        guyAnimation = GetComponent<Animator>();
        playerBody = GetComponent<CapsuleCollider2D>();
    }

    void Update()
    {
        Walk();
        Flip();
    }

    void OnMove(InputValue value)
    {
        movingInput = value.Get<Vector2>();

        Debug.Log(movingInput);
    }
    void Walk()
    {
        Vector2 playerVelocity = new Vector2 (movingInput.x * fltRunSpd, myRB.velocity.y);
        myRB.velocity = playerVelocity;
        bool blnPlayerHasHorizontalSpeed = Mathf.Abs(myRB.velocity.x) > Mathf.Epsilon;
        guyAnimation.SetBool("blnRunning", blnPlayerHasHorizontalSpeed);
    }
    void Flip()
    {
        bool blnPlayerHasHorizontalSpeed = Mathf.Abs(myRB.velocity.x) > Mathf.Epsilon;
        if (blnPlayerHasHorizontalSpeed)
        {
        transform.localScale = new Vector2 (Mathf.Sign(-myRB.velocity.x), 1f);
        }
    } 
}
