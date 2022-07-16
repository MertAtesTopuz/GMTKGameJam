using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public float wait = 3f;

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
        this.gameObject.SetActive(false);
    }

}
