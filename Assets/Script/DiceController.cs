using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using TMPro;

public class DiceController : MonoBehaviour
{
    private static FieldInfo m_FalloffField = typeof(Light2D).GetField("m_FalloffIntensity", BindingFlags.NonPublic | BindingFlags.Instance);
    public int remainingDice = 1;
    private Animator animator;
    public Image oldImage;
    public Sprite[] dice;
    public Light2D lght;
    public TextMeshProUGUI diceTxt;

    void Start()
    {
        animator = GetComponent<Animator>();
      //  oldImage = GetComponent<Image>();
    }

    void Update()
    {
        diceTxt.text = "Dice Remaininin = " + remainingDice;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (remainingDice > 0)
            {
                StartCoroutine(waitanimation());
            }
        }
    }

    public void SetFalloff(float falloff)
    {
        m_FalloffField.SetValue(lght, falloff);
    }

    void RollTheDice(){
        if (remainingDice > 0)
        {

            remainingDice -= 1;
            int rand = Random.Range(0, 6);
            for (int i = 0; i < dice.Length; i++)
            {
                if (i == rand)
                {
                    gameObject.GetComponent<Image>().sprite = dice[i];
                    lght.pointLightOuterRadius = 2 * (rand + 1.5f);
                    if (rand == 0)
                    {
                        lght.pointLightOuterRadius = 4;
                    }
                    break;
                }
            }
        }
    }

    IEnumerator waitanimation()
    {
        animator.enabled = true;
        animator.Play("DiceRoll");
        yield return new WaitForSeconds(1.1f);
        animator.enabled = false;
        RollTheDice();

    }
}
