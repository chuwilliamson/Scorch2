using UnityEngine;
using System.Collections;

public class CProjectile : MonoBehaviour {

    public float speed;
    public float lifetime;
    public float damage;

    private Transform tr;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {

        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();

        rb.AddForce(tr.forward * speed);
	}
	
	// Update is called once per frame
	void Update () {

        lifetime -= Time.deltaTime;

        if (lifetime < 0)
            Destroy(this.gameObject);
	}
}
