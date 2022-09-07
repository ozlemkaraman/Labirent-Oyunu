using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnengel : MonoBehaviour
{
    public GameObject[] objeler;
    public Transform[] nokta;
    void Start()
    {
        for (int i = 0; i<7; i++)
        {
            Instantiate(objeler[Random.Range(0, objeler.Length)], nokta[Random.Range(0, nokta.Length)].position, Quaternion.identity);
        }
    }

    
    void Update()
    {
        
    }
}
