using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ToggleChangeManager : MonoBehaviour {
	private Toggle toggle;

	// Use this for initialization
	void Start () {
		toggle = GetComponent<Toggle> ();
	}

	public void PrintNewToggleValue(){
		bool status = toggle.isOn;
		print ("Toggle is: " + status);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
