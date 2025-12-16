using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;
    public float liftingForce;

    public bool jumped;
    public bool doubleJumped;

    public LayerMask whatIsGround;

    private Rigidbody2D rb;
    private float timestamp;
    private BoxCollider2D boxCollider2D;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // je¿eli aktualnie nie trwa gra nie wykonuj reszty metody
        if (!GameManager.instance.inGame) return;

        if (IsGrounded() && Time.time >= timestamp)
        {
            if (jumped || doubleJumped)
            {
                jumped = false;
                doubleJumped = false;
            }

            timestamp = Time.time + 1f;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (!jumped)
            {
                rb.velocity = (new Vector2(0f, jumpForce));
                jumped = true;
            }
            else if (!doubleJumped)
            {
                rb.velocity = (new Vector2(0f, jumpForce));
                doubleJumped = true;
            }
        }

        if (Input.GetMouseButtonDown(0) && rb.velocity.y <= 0)
        {
            rb.AddForce(new Vector2(0f, liftingForce * Time.deltaTime));
        }

    }

    private bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, 0.1f, whatIsGround);
        return hit.collider != null;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            PlayerDeath();
        }
    }

    void PlayerDeath()
    {
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        GameManager.instance.GameOver();
    }
}