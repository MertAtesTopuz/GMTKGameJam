using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float bounce = 20f;
    private Animator animator;
    public AudioClip bounceSfx;
    AudioSource sesdosyasi;

    void Start()
    {
        animator = GetComponent<Animator>();
        sesdosyasi = gameObject.GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            animator.Play("jumppad");
            sesdosyasi.PlayOneShot(bounceSfx);
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
        }
    }
}
