using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawning : MonoBehaviour
{
    public Text score;
    public Transform transformsp;
    public GameObject platform;
    public float RandomX;
 
    public float altitudemax;
    public float altitudeactual;
    public float spawnaltitude;
    public float spawntrigger;
    // Start is called before the first frame update
    void Start()
    {
        altitudeactual = transformsp.position.y;
        spawnaltitude = altitudeactual;
        altitudemax = altitudeactual;
        RandomX = Random.Range(-8.9f + 2.75f / 2f, 8.9f - 2.75f / 2f);
        Instantiate(platform, new Vector3(RandomX, 6, 0f), Quaternion.identity);
        spawntrigger = 3;
    }

    // Update is called once per frame
    void Update()
    {
        altitudeactual = transformsp.position.y;
        spawntrigger = 10 - Mathf.Round(altitudemax / 100);
        if (spawntrigger > 6)
        {
            spawntrigger = 6;
        }
        if (altitudemax - spawnaltitude >= 3)
        {
            Spawn();
            spawnaltitude = altitudeactual;
        }
        if (altitudeactual > altitudemax) { 
            altitudemax = altitudeactual;
        
        }
        Count();
        
    }
    void Count()
    {
    score.text="Score:"+ Mathf.Round(altitudemax-6);
       
    }
    void Spawn() {
        RandomX = Random.Range(-8.9f + 2.75f / 2f, 8.9f - 2.75f / 2f);
        Instantiate(platform, new Vector3(RandomX, transformsp.position.y, 0f), Quaternion.identity);

    }
    



    
}
