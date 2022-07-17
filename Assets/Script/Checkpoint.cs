using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private GameManager manager;
    private Animator animator;

    public AudioClip checkpoint;
    AudioSource sesdosyasi;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameManager>();
        animator = GetComponent<Animator>();
        sesdosyasi = gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            animator.Play("Checkpoint");
            manager.lastCheckPointPos = transform.position;
            sesdosyasi.PlayOneShot(checkpoint);
            animator.SetBool("isCheck", true);
        }
    }
}
