using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AdjustScript : MonoBehaviour {

	private void OnGUI()
	{
        int rectR = 10;
        int rectL = 120;
        int rectH = 30;


        if (GUI.Button(new Rect(rectR, 100, rectL, rectH), "Health up"))
        {
            GameControl.control.health += 10;
        }
        if (GUI.Button(new Rect(rectR, 150, rectL, rectH), "Health down"))
        {
            GameControl.control.health -= 10;
        }
        if (GUI.Button(new Rect(rectR, 200, rectL, rectH), "Experience up"))
        {
            GameControl.control.experience += 10;
        }
        if (GUI.Button(new Rect(rectR, 250, rectL, rectH), "Experience down"))
        {
            GameControl.control.experience -= 10;
        }
        if (GUI.Button(new Rect(rectR, 300, rectL, rectH), "Save"))
        {
            GameControl.control.Save();
        }
        if (GUI.Button(new Rect(rectR, 350, rectL, rectH), "Load"))
        {
            GameControl.control.Load();
        }
	}
}
