using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableparticle : MonoBehaviour
{
    public GameObject particles3;
    // Use this for initialization
    void Start()
    {
        particles3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "particleactivator")
        {
            Debug.Log("particlesON");
            particles3.SetActive(true);

        }





        }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "particleactivator")
        {
            Debug.Log("particlesOff");
            particles3.SetActive(false);

        }
    }
}
