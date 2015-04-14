using UnityEngine;
using System.Collections;

public class WeaponText : MonoBehaviour 
{

    enum WeaponType { PISTOL = 0, RIFLE = 1, SMG = 2, LAUNCHER = 3 }  
	int currentWeapon;

	void Start () 
	{
	
	}

	void Update () 
	{
        OnGUI();
	}

	void OnGUI()
	{
		GUI.TextField(new Rect (10,30,200, 20), "Current weapon: ");

    }



}
