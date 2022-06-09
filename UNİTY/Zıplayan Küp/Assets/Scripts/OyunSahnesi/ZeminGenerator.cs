using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminGenerator : MonoBehaviour
{
    public GameObject Zemin;
    public int ZeminSayýsý;
    public float ZeminGeniþlik;
    public float Minimumy, Maximumy;
    public Transform tr;
    private void Start()
    {
        tr = transform.GetComponent<Transform>();
        Vector3 SpawnKonumu = new Vector3();
        Vector2 YeniScale = new Vector2();
        for (int i = 0; i < ZeminSayýsý; i++)
        {
            YeniScale.x = Random.Range(0.9f, 1.1f);
            YeniScale.y = Random.Range(0.9f, 1.1f);
            tr.localScale = YeniScale;

            SpawnKonumu.y += Random.Range(Minimumy, Maximumy);
            SpawnKonumu.x = Random.Range(-ZeminGeniþlik, ZeminGeniþlik);

            Instantiate(Zemin,SpawnKonumu,Quaternion.identity); 
        }
    }


}
