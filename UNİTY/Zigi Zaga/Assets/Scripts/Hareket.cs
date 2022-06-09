using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    Vector3 Y�n;
    public float H�z;
    public ZeminSpawner zeminSpawnerScripti;
    public static bool D��t�_m�;
    public float EklenecekH�z;
    void Start()
    {
        Y�n = Vector3.left;
        D��t�_m� = false;
    }


    void Update()
    {

        if (transform.position.y <= 0.5f)
        {
            Debug.Log("D��T�MM");
            D��t�_m� = true;
        }

        if (D��t�_m� == true)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (Y�n.z == 0)
            {
                Y�n = Vector3.back;
            }
            else
            {
                Y�n = Vector3.left;
            }
            H�z = H�z + EklenecekH�z * Time.deltaTime;

        }
    }
    private void FixedUpdate()
    {
        Vector3 Hareket = Y�n * Time.deltaTime * H�z;
        transform.position += Hareket;
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Zemin")
        {
            Skor.skor++;
            collision.gameObject.AddComponent<Rigidbody>(); 
            zeminSpawnerScripti.Zemin_Olu�tur();
            StartCoroutine(ZeminSil(collision.gameObject));


        }

    }

    IEnumerator ZeminSil(GameObject SilinecekZemin)
    {
        yield return new WaitForSeconds(3f);
        Destroy(SilinecekZemin);



    }


}
