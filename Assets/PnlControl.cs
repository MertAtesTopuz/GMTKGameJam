using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PnlControl : MonoBehaviour
{
    public GameObject durdur_pnl;

    private void Update()
    {

    }

   // [System.Obsolete]

    public void menu_don_btn()
    {

        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }

    public void devam_et_btn()
    {

        Time.timeScale = 1.0f;
        durdur_pnl.SetActive(false);
    }

    public void durdur_btn()
    {

        Time.timeScale = 0.0f;
        durdur_pnl.SetActive(true);
    }
    public void tekrar_btn()
    {

        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
