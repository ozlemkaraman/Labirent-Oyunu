using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zaman : MonoBehaviour
{
    public float zamann, verilen;
    public Text s�re;


    void Start()
    {
        zamann = verilen;
    }

    
    void Update()
    {
        s�re.text = zamann.ToString("f2");
        zamann -= Time.deltaTime;
        if(zamann<= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }

    }
}
