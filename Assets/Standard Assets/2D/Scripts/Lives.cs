using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Lives : MonoBehaviour
{

    public GameObject Gameover;
    public GameObject Enviorment;
    public GameObject Character;

    public static float life;
    private Rigidbody2D rb;
    public float flashSpeed;





    SpriteRenderer spRndrer;

    void Start()
    {

        Gameover.SetActive(false);
        Enviorment.SetActive(true);
        Character.SetActive(true);

        rb = gameObject.GetComponent<Rigidbody2D>();
        spRndrer = GetComponent<SpriteRenderer>();
        life = 4;
        Cursor.visible = false;
     



    }

    void Update()
    {
        if (life == 3)
        {
            Debug.Log("life is now 3");
            Destroy(GameObject.Find("Life4"));

        }


        if (life == 2)
        {
            Debug.Log("life is now 2");
            Destroy(GameObject.Find("Life3"));

        }


        if (life == 1)
        {
            Debug.Log("life is now 1");
            Destroy(GameObject.Find("Life2"));

        }

        if (life == 0)
        {
            Destroy(GameObject.Find("Life1"));
            Debug.Log("GameOver");
            Cursor.visible = true;
            Gameover.SetActive(true);
            Enviorment.SetActive(false);
            Character.SetActive(false);


        }


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
            rb.AddForce(Vector3.up * 930f);
        }

        if(other.tag == "Level2")
        {
            SceneManager.LoadScene("Level2");
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
