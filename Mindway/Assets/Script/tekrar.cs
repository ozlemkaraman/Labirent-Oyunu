using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tekrar : MonoBehaviour
{
    public float y�kseklik, zaman, verilenzaman, z�plamagucu;
    public Transform �lk;
  //  public Text Timer;

    void Start()
    {
    //    zaman = verilenzaman;

    }
     void Update()
    {
      //  zaman -= Time.deltaTime;
      //  Timer.text = zaman.ToString("f2");
        if (transform.position.y <= y�kseklik)
        {
            transform.position = �lk.position;
        }

       // if (zaman <= 0)
        //{
          //  transform.position = �lk.position;
           // zaman = verilenzaman;

       // }
       if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * z�plamagucu);
        }
    }
     void OnCollisionEnter(Collision temasEdilen)
    {
        if(temasEdilen.gameObject.tag =="bitis")
        {
            Application.LoadLevel(2);
        }
    }




}
