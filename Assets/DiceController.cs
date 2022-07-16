using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceController : MonoBehaviour
{
    private Animator animator;
    public Sprite on;
    public Sprite off;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    void RollTheDice(){
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("isRolling");
        }
    }
}
