using System;
using UnityEngine;

public class AnimationsController : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private float animatorTriggerOffset = 0.1f;
    private PlayerMovement playerMovementScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerMovementScript = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMovementScript.isPlayerDead)
        {
            animator.SetTrigger("Death");
        }
        else
        {
            if (rb.linearVelocityX < -animatorTriggerOffset)
            {
                spriteRenderer.flipX = true;
            }
            else if (rb.linearVelocityX > animatorTriggerOffset)
            {
                spriteRenderer.flipX = false;
            }

            if (Math.Abs(rb.linearVelocityX) > animatorTriggerOffset && Math.Abs(rb.linearVelocityY) < animatorTriggerOffset)
            {
                animator.Play("Run");
            }
            else if (rb.linearVelocityY > animatorTriggerOffset)
            {
                animator.Play("Jump");
            }
            else if (rb.linearVelocityY < -animatorTriggerOffset)
            {
                animator.Play("Fall");
            }
            else
            {
                animator.Play("Idle");
            }
        }
    }

    public void PlayerDeath()
    {
        GameManager.Instance.EnableGameOverScreen();
        Destroy(gameObject);
    }
}
