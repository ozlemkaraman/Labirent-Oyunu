using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tekrar : MonoBehaviour
{
    public float yükseklik, zaman, verilenzaman, zýplamagucu;
    public Transform Ýlk;
  //  public Text Timer;

    void Start()
    {
    //    zaman = verilenzaman;

    }
     void Update()
    {
      //  zaman -= Time.deltaTime;
      //  Timer.text = zaman.ToString("f2");
        if (transform.position.y <= yükseklik)
        {
            transform.position = Ýlk.position;
        }

       // if (zaman <= 0)
        //{
          //  transform.position = Ýlk.position;
           // zaman = verilenzaman;

       // }
       if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * zýplamagucu);
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
