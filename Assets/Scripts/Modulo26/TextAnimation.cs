using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextAnimation : MonoBehaviour
{
    public float timeBetweenLetters = 0.2f;
    public TMP_Text tmpText;

    public string phrase;

    private void Awake()
    {
        tmpText.text = "";
    }
    public void StartAnimation()
    {
        StartCoroutine(StartLettersAnimation(phrase));
    }
    IEnumerator StartLettersAnimation(string s)
    {
        tmpText.text = "";

        foreach(char c in s.ToCharArray())
        {
            tmpText.text += c;
            yield return new WaitForSeconds(timeBetweenLetters);
        }
    }
}
