using UnityEngine;
using System.Collections;

public class CEnemy : MonoBehaviour {
	public float e_hp;
	public float e_damage;
	public CTakeDamage takeDamage;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		int enemyCount = GameObject.FindGameObjectsWithTag ("Enemy").Length;
	}
}
