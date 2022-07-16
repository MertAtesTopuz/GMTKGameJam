using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager manager;
    public Vector2 lastCheckPointPos;

    private void Awake()
    {
        if(manager == null)
        {
            manager = this;
            DontDestroyOnLoad(manager);
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
