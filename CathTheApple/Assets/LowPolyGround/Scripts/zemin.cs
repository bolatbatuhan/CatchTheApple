using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zemin : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "elma")
        {
            float rast = Random.Range(-3.3f, 13.1f);

            collision.gameObject.transform.position = new Vector3(rast, 8, -7);
        }
    }
}
