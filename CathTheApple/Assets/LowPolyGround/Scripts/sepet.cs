using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sepet : MonoBehaviour
{

    public float hiz; 

    int skor = 0;
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "elma")
        {
            skor += 10;
            Debug.Log(skor.ToString());

            float rast = Random.Range(-3.3f, 13.1f);

            collision.gameObject.transform.position = new Vector3(rast, 8, -7);
        }
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)) 
        {
            transform.Translate(hiz*Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-hiz * Time.deltaTime, 0, 0);
        }
    }
}
