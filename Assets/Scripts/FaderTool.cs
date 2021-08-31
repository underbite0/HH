using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FaderTool : MonoBehaviour {
    //name of the scene you want to load
    public string scene;
	public Color loadToColor = Color.white;
	
	public void GoFade()
    {
        Initiate.Fade(scene, loadToColor, 1.0f);
    }
}
