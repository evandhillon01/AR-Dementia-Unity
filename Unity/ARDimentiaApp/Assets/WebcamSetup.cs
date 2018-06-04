using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Material))]
public class WebcamSetup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		WebCamTexture newTexture = new WebCamTexture ();
		Renderer rend = GetComponent<Renderer>();
		rend.material.SetTexture("_MainTex", newTexture);
		newTexture.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
