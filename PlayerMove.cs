using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidbody2DPlayer;
   
    public float movementSpeed;
    
    public float higthJump;
    private float horizontalMove;
    public Animator animation;
    public SpriteRenderer sprite;
    public Transform groundCheck;
    
    public bool isGround;
    public LayerMask groundLayer;




    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        Vector3 movement = new Vector3(horizontalMove, 0, 0);
        transform.position += movementSpeed * Time.deltaTime * movement;
        Flip(horizontalMove);



        animation.SetFloat("Horizontal", Mathf.Abs(horizontalMove));

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (isGround)
            {
                Jump();
                
            }

           

        }


    }
    private void FixedUpdate()
    {
        GroundCheck();
    }
    void Flip(float horizontalMove)
    {
        if (horizontalMove == 1)
        {
            sprite.flipX = false;

        }
        else if (horizontalMove == -1)
        {
            sprite.flipX = true;

        }
    }
    void Jump()
    {
        rigidbody2DPlayer.AddForce(higthJump * transform.up);
        animation.SetBool("isGround", true);
    }
    void GroundCheck()
    {
        isGround = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
        animation.SetBool("isGround", false);
    }


}
