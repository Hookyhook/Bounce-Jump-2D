using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    public GameObject Player;
    public Transform tr;
    public float altitudemax;
    public float altitudeactual;
    void Start()
    {
        altitudeactual = Player.transform.position.y; 
        altitudemax = altitudeactual;
    }

    // Update is called once per frame
    void Update()
    {
        altitudeactual = Player.transform.position.y;
        if (altitudeactual > altitudemax)
        {
            altitudemax = altitudeactual;
            tr.position = new Vector3(0f, Player.transform.position.y, 0f);

        }
        
        
        
         
    }
}
