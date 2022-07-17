using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public GameObject plat;
    public float wait = 3f;
    public AudioSource platformUp;

    private void Start()
    {
    }

    private void Update()
    {
        if (plat.gameObject.activeSelf == false)
        {
            StartCoroutine(waitanimation());
        }
    }

    IEnumerator waitanimation()
    {
        
        yield return new WaitForSeconds(wait);
        platformUp.Play();
        plat.gameObject.SetActive(true);
        
    }
}
