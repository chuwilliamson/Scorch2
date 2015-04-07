using UnityEngine;
using System.Collections;

public class CWeaponPickup : MonoBehaviour {

    public string type;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // set players current weapon equal 
            // to the weapon data for this pickup
            other.GetComponentInChildren<CPlayerWeapon>().WeaponPickup(GetComponentInChildren<CWeapon>());
            Destroy(this.gameObject);
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
