using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    
    public void Close()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
