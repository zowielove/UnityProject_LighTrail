using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using DG.Tweening;
using System;

public class Text_typing : MonoBehaviour
{
    public TMP_Text teamname;
    [SerializeField] string text;
    [SerializeField] float fadeTime;

    void Start()
    {
        text = $"{text}";
        StartCoroutine(Typing(text));
        
    }


    IEnumerator Typing( string typing )
    {
        teamname.text = null;
        for ( int i = 0; i < typing.Length; i++ )
        {
            teamname.text += typing [i];
            yield return new WaitForSeconds(0.1f);
        }
        yield return new WaitForSeconds(2f);
        StartCoroutine(FaFadeOut());

    }

    IEnumerator FaFadeOut()
    {
        float rate = 0;
        Color fadeOutColor = new Color(teamname.color.r, teamname.color.g, teamname.color.b, 0f);
        Color fadeInColor = new Color(teamname.color.r, teamname.color.g, teamname.color.b, 1f);

        while ( rate <= 1 )
        {
            rate += Time.deltaTime / fadeTime;
            teamname.color = Color.Lerp(fadeInColor, fadeOutColor, rate);
            yield return null;
        }
        yield return new WaitForSeconds(1.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("01.Title_ver2");

    }

}
