using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class menuscript : MonoBehaviour {

	public void Changescene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }

    
}
