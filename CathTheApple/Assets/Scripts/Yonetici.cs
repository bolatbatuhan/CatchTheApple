using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yonetici : MonoBehaviour
{
    
    public GameObject elma;

    float zaman_araligi = 0.5f;
    float kalan_zaman = 0.0f;
    
    void Start()
    {

        //InvokeRepeating("elma_ekle",0.0f, 0.5f);
    }

    void elma_ekle()
    {
        float rast = Random.Range(-3.3f, 13.1f);
        GameObject yeni_elma = Instantiate(elma,new Vector3(rast,8,-7),Quaternion.identity);

    }

    private void Update()
    {
        if(Time.time >= kalan_zaman)
        {
            elma_ekle();
            kalan_zaman = zaman_araligi + Time.time;
        }
    }

}
