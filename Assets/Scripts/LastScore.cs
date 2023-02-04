using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LastScore : MonoBehaviour
{
    public int LastScorel;
    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        LastScorel = PlayerPrefs.GetInt("lastround");
        text.text = "Last Score: "+ LastScorel.ToString();
    }
}
