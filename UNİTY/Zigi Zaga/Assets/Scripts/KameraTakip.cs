using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public Transform TopunKonumu;
    Vector3 Fark;
    void Start()
    {
        Fark = transform.position - TopunKonumu.position;
    }


    void Update()
    {
        if (Hareket.Düþtü_mü == false)
        {
            transform.position = TopunKonumu.position + Fark;
        }

    }
}
