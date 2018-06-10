using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class exitgame : MonoBehaviour {

	// Use this for initialization

	
	// Update is called once per frame
	public void QuitGame() {


        Debug.Log("Game is exiting");
        Application.Quit();
           
            //Just to make sure its working
        }


    }

