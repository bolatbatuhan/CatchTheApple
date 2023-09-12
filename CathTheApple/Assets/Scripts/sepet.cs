using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sepet : MonoBehaviour
{

    public float hiz;

    int skor = 0;

    public TextMeshProUGUI skor2_txt;
    
    public ParticleSystem efekt;

    private void Start()
    {
        efekt.Stop();
    }




    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "elma")
        {
            efekt.Play();
            skor += 10;
            skor2_txt.text = skor.ToString();
            skor2_txt.color = Color.red;
            Destroy(collision.gameObject);
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(hiz * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-hiz * Time.deltaTime, 0, 0);
        }
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override bool Equals(object other)
    {
        return base.Equals(other);
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
