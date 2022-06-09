using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    Vector3 Yön;
    public float Hýz;
    public ZeminSpawner zeminSpawnerScripti;
    public static bool Düþtü_mü;
    public float EklenecekHýz;
    void Start()
    {
        Yön = Vector3.left;
        Düþtü_mü = false;
    }


    void Update()
    {

        if (transform.position.y <= 0.5f)
        {
            Debug.Log("DÜÞTÜMM");
            Düþtü_mü = true;
        }

        if (Düþtü_mü == true)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (Yön.z == 0)
            {
                Yön = Vector3.back;
            }
            else
            {
                Yön = Vector3.left;
            }
            Hýz = Hýz + EklenecekHýz * Time.deltaTime;

        }
    }
    private void FixedUpdate()
    {
        Vector3 Hareket = Yön * Time.deltaTime * Hýz;
        transform.position += Hareket;
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Zemin")
        {
            Skor.skor++;
            collision.gameObject.AddComponent<Rigidbody>(); 
            zeminSpawnerScripti.Zemin_Oluþtur();
            StartCoroutine(ZeminSil(collision.gameObject));


        }

    }

    IEnumerator ZeminSil(GameObject SilinecekZemin)
    {
        yield return new WaitForSeconds(3f);
        Destroy(SilinecekZemin);



    }


}
