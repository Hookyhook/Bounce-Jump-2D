using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    public Text score;
    public GameObject Player;
    public float Score;
    // Start is called before the first frame update
    void Start()
    {
        score.text = "Score:0";
    }

    // Update is called once per frame
    void Update()
    {
        Score = Mathf.Round(Player.transform.position.y);
        if (Score < 0) { Score = 0; }
        score.text = "Score:" + score;
    }
}
