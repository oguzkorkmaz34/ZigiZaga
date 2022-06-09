using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zemin : MonoBehaviour
{

    public float ZeminKuvveti;
    public bool ZemineTemasEdildi;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0) ;
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Vector2 ZıplamaVelocity = rb.velocity;
                ZıplamaVelocity.y = ZeminKuvveti;
                rb.velocity = ZıplamaVelocity;

                if (ZemineTemasEdildi == false)
                {
                    Yönetici.SkorSayısı++;
                    ZemineTemasEdildi = true;
                }

                anim.SetBool("TemasEdildi", true);
                Destroy(gameObject, 1f);
            }



        }



    }



}
