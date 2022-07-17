using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceUpgrade : MonoBehaviour
{
    public int upgrade;
    public GameObject pressE;
    private DiceController dice;

    private void Start()
    {
        dice = GameObject.Find("Dice").GetComponent<DiceController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            pressE.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                dice.remainingDice += upgrade;
                Destroy(this.gameObject);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                dice.remainingDice += upgrade;
                Destroy(this.gameObject);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        pressE.SetActive(false);
    }
}
