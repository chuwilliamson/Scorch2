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
        GUI.TextArea(new Rect (10,30,200, 20), "Current weapon: " );
	}


	void weaponState ()
	{
		switch(currentWeapon)
		{
		case 3: 
			print ("Grenade Launcher");
			break;
		case 2:
			print ("SMG");
			break;
		case 1:
			print ("Assault Rifle");
			break;
		default:
			print ("Pistol");
			break;
		}

	}

	void OnGUI()
	{
		//GUI.(new Rect (10,30,200, 20), "Current weapon: " );
		
	}

}
