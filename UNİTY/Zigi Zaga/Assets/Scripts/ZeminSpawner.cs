using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminSpawner : MonoBehaviour
{
    public GameObject Son_Zemin;

    public void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            Zemin_Olu�tur();

        }
    }

    public void Zemin_Olu�tur()
    {
        Vector3 y�n;
        if (Random.Range(0, 2) == 0)
        {
            y�n = Vector3.left;

        }
        else
        {
            y�n = Vector3.back;
        }

        Son_Zemin = Instantiate(Son_Zemin, Son_Zemin.transform.position + y�n, Son_Zemin.transform.rotation);


    }
}
