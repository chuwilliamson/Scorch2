using UnityEngine;
using System.Collections;

public class CTakeDamage : MonoBehaviour {

    public float health;

    void OnCollisionEnter(Collision a_col)
    {
        if(this.CompareTag("bullet"))
        {
            health = -1;
        }

        if (this.CompareTag("Enemy") && a_col.transform.gameObject.CompareTag("bullet"))
        {
            health -= a_col.transform.gameObject.GetComponent<CProjectile>().damage;
            Debug.Log(health);
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (health < 0)
            Destroy(this.gameObject);
	}
}
