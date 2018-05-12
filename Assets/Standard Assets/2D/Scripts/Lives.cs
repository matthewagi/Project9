using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Lives : MonoBehaviour
{
    public static float life;
    private Rigidbody2D rb;
    public float flashSpeed;
  
    SpriteRenderer spRndrer;

    void Start()
    {

        rb = gameObject.GetComponent<Rigidbody2D>();
        spRndrer = GetComponent<SpriteRenderer>();
        life = 4;

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "bounderies")
        {

            life--;
            Debug.Log(life);
            transform.position = new Vector3(-6, 2, 0);
            StartCoroutine(Flash(flashSpeed));
        }
        if (other.tag == "Hazard")
        {
            Debug.Log("hit hazard");
            life --;
            StartCoroutine(Flash(flashSpeed));
        }

        if (other.tag == "Spike")
        {
            Debug.Log("hit spike");
            life--;
            StartCoroutine(Flash(flashSpeed));
        }

        if (other.tag == "Boost")
        {
            Debug.Log("boost");
            rb.AddForce(Vector3.up * 630f);
        }

    }


    IEnumerator Flash(float x)
    {
        
        for (int i = 0; i < 10; i++)
        {
            spRndrer.enabled = false;
            yield return new WaitForSeconds(x);
            spRndrer.enabled = true;
            yield return new WaitForSeconds(x);
        }
       
    }
}
