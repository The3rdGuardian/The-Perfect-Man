using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static int sceneCount;

    public int body_part = 0;


    private bool facingRight = true;
    public bool isJumping = false;

    private Rigidbody2D rb2d;

    public float speed;
    public float jump;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();   
    }

    void Update()
    {
            if (Input.GetKey(KeyCode.W) && isJumping == false)
            {
                rb2d.AddForce(new Vector2(0, 4), ForceMode2D.Impulse);
            }
    }

    void FixedUpdate()
    {
        float hozMovement = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(hozMovement * speed, rb2d.velocity.y);

        if (facingRight == false && hozMovement > 0)
        {
            Flip();
        }
    }
   public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isJumping = false;
        }


        if (other.gameObject.tag == "Portal")
        {
            if (body_part == 0)
            {
                sceneCount = 2;
                SceneManager.LoadScene("Level 1");
            }

            if (body_part == 1)
            {
                sceneCount = 3;
                SceneManager.LoadScene("Level 2");
            }

            if (body_part == 2)
            {
                sceneCount = 4;
                SceneManager.LoadScene("Level 3");
            }
            if (sceneCount == 2)
            {
                transform.position = new Vector2(-16.84f, -6.22f);
                //Destroy(GameObject start1);
            }
        }
    }
      void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = true;
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector2 Scaler = transform.localScale;
        Scaler.x = Scaler.x * -1;
        transform.localScale = Scaler;
    }
}






//anim.SetFloat("speed", Mathf.Abs(hozMovement));

//isGrounded = Physics2D.OverlapCircle(groundchecker.position, groundcheck, ground);
//anim.SetBool("isGrounded", isGrounded);

//anim.SetFloat("verticalSpeed", rb2d.velocity.y);




/*if (isGrounded && Input.GetAxis("Jump") > 0)
{
    isGrounded = false;
    anim.SetBool("isGrounded", isGrounded);
    rb2d.AddForce(new Vector2(0, jumpheight));
}*/

/*
  if(Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(new Vector2(rb2d.velocity.x, jump));

        }
*/



/* RaycastHit2D raycast = Physics2D.Raycast(transform.position, Vector2.down);

      if (raycast)
      {
          isGrounded = true;
          Debug.Log("Grounded");
      }
      else
      {
          isGrounded = false;
          Debug.Log("Floating");
      }

      if (raycast.collider != null)
      {
          if (Input.GetKeyDown(KeyCode.Space))
          {
              rb2d.AddForce(Vector2.up * jump);
          }
      }
      Debug.DrawRay(transform.position, Vector2.down, Color.red);
      */
