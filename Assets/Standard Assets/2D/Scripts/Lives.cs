using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public static float life;




    void Start()
    {

        life = 4;

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "bounderies")
        {

            life--;
            Debug.Log(life);
            transform.position = new Vector3(-6, 2, 0);
 }
        if (other.tag == "Hazard")
        {
            life --;
            StartCoroutine(Flasher);
        }

    }


    IEnumerator Flasher()
    {
        for (int i = 0; i < 5; i++)
        {
            renderer.material.color = collideColor;
            yield return new WaitForSeconds(.1f);
            renderer.material.color = normalColor;
            yield return new WaitForSeconds(.1f);
        }
    }
}