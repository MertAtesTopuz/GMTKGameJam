using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public float wait = 3f;
    public AudioSource platformDown;

    private void Start()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {

            StartCoroutine(waitanimation());
        }
    }

    IEnumerator waitanimation()
    {
        
        yield return new WaitForSeconds(wait);
        platformDown.Play();
        this.gameObject.SetActive(false);
        
    }

}
