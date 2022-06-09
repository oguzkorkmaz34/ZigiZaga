using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterHareket : MonoBehaviour
{
    public float HareketHýzý;
    private float YatayHareket;
    Rigidbody2D rb;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        YatayHareket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(YatayHareket * HareketHýzý * Time.deltaTime, rb.velocity.y);

        Vector2 YeniScale = transform.localScale;
        if (YatayHareket > 0)
        {
            YeniScale.x = 0.35f;
        }
        if (YatayHareket < 0)
        {
            YeniScale.x = -0.35f;
        }

        transform.localScale = YeniScale;

    }
}
