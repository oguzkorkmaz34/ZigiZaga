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
            Zemin_Oluþtur();

        }
    }

    public void Zemin_Oluþtur()
    {
        Vector3 yön;
        if (Random.Range(0, 2) == 0)
        {
            yön = Vector3.left;

        }
        else
        {
            yön = Vector3.back;
        }

        Son_Zemin = Instantiate(Son_Zemin, Son_Zemin.transform.position + yön, Son_Zemin.transform.rotation);


    }
}
