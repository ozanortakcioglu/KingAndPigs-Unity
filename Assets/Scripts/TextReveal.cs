using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextReveal : MonoBehaviour
{
    private TMP_Text tmPro;
    TMP_TextInfo textInfo;
    bool IsWriting = false;
    public PopUpController popUpController;
    int downCounter = 0;

    void Awake()
    {
        tmPro = GetComponent<TMP_Text>();
    }
    void Start()
    {
        tmPro.maxVisibleCharacters = 0;
        tmPro.text = "I can't believe I lost one's castle to those pigs! Thou shall taste one's hammah!";
        StartCoroutine(Reveal());
    }
    private void FixedUpdate()
    {
        if (downCounter == 2)
        {
            tmPro.maxVisibleCharacters = 0;
            popUpController.Down();
        }
    }
    public void Trigger()
    {
        if (!IsWriting)
        {
            tmPro.maxVisibleCharacters = 0;
            tmPro.text = "Oh, I forgot that we don't have stairs in the entrance. I am toohh old for this.";
            StartCoroutine(Reveal());
        }

    }

    IEnumerator Reveal()
    {
        textInfo = tmPro.textInfo;
        IsWriting = true;
        bool isRangeMax = false;
        int counter = 0;

        yield return new WaitForSeconds(0.3f);

        while (!isRangeMax)
        {
            int characterCount = textInfo.characterCount;
            tmPro.maxVisibleCharacters = counter;
            yield return new WaitForSeconds(0.02f);
            //Debug.Log(counter);
            //Debug.Log(characterCount);
            if (counter != 0)
            {
                if (counter == characterCount)
                {
                    isRangeMax = true;
                    IsWriting = false;
                    yield return new WaitForSeconds(1f);
                    downCounter++;
                }
            }
            if (counter < characterCount)
            {
                counter += 1;
            }

        }
        
    }


}
