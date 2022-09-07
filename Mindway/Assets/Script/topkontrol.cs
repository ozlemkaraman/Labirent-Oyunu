using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topkontrol : MonoBehaviour
{
    public UnityEngine.UI.Text zaman;


    private Rigidbody rg;
    public float Hiz = 2f;
    
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }
    void Update()  
    {
        
    }
     void FixedUpdate()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        Vector3 kuvvet = new Vector3(-dikey, 0, yatay);
        rg.AddForce(kuvvet * Hiz);
    }
    void OnCollisionEnter(Collision cls)

    {
        string objIsmi = cls.gameObject.name;
        if (objIsmi.Equals("bitis"))
        {
            print("Oyun Tamamlandý.");
        }
    }
}
