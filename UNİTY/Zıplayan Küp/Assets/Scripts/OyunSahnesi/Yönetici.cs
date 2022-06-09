using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yönetici : MonoBehaviour
{
    public Text Skor;
    public static float SkorSayısı;
    

    
    void Update()
    {
        Skor.text=SkorSayısı.ToString();
        
    }
}
