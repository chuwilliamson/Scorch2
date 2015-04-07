using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CPlayerWeapon : CWeapon {

    public void WeaponPickup(CWeapon weapon)
    {
        rof = weapon.rof;
        damage = weapon.damage;
        lifetime = weapon.lifetime;
        projectile = weapon.projectile;
        bucket = weapon.bucket;

        Debug.Log(rof);
        Debug.Log(damage);
    }

    void Awake()
    {
         
    }

	// Use this for initialization
	void Start () {

        base.Start();
	}
	
	// Update is called once per frame
	void Update () {

        base.Update();
	
	}
}

