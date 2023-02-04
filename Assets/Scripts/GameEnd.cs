using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    private int lastscore;
    void OnTriggerEnter2D(Collider2D Collider)
    {
       lastscore=Mathf.RoundToInt(GameObject.Find("Spawner").GetComponent<Spawning>().altitudemax)-6;
       PlayerPrefs.SetInt("lastround", lastscore);
       SceneManager.LoadScene(0);
    }
   
}
