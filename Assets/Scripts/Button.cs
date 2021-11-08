using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
	public bool isPressed; 

	public void OnButtonPress(){
		// if button has been pressed, set isPressed to true
		isPressed = true;
	}
}
