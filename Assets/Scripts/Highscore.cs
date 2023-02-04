using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Highscore : MonoBehaviour
{
    public int LastScorel;
    public TMP_Text text;
    public int Highscorel = 0;

    // Update is called once per frame
    void Update()
    {
        Highscorel = PlayerPrefs.GetInt("highscore");
        LastScorel = PlayerPrefs.GetInt("lastround");
        if (LastScorel > Highscorel)
        {
            Highscorel = LastScorel;
        }
        text.text = "Highscore: " + Highscorel;
        PlayerPrefs.SetInt("highscore",Highscorel);
    }
}
