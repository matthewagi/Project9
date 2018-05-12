using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuscript : MonoBehaviour {

	public void Changescene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
