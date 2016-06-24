using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RadioButtonManager : MonoBehaviour {
	private string currentDifficulty = "Easy";

	public void PrintNewGroupValue(Toggle sender) {
		if (sender.isOn) {
			currentDifficulty = sender.tag;
			print ("Option changed to: " + currentDifficulty);
		}
	}
}
