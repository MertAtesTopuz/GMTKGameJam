using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Sing : MonoBehaviour
{
    public GameObject txt;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            txt.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        txt.SetActive(false);
    }
}
