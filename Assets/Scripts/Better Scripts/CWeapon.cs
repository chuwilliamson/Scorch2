using UnityEngine;
using System.Collections;

public class CWeapon : MonoBehaviour
{

    public float rof;
    public float damage;
    public float lifetime;
    public string type;
    public GameObject projectile;
    public GameObject bucket;
    private float timer;

    // Use this for initialization
    public void Start()
    { 
        timer = rof;
    }

    // Update is called once per frame
    public void Update()
    {

        if (Input.GetKey(KeyCode.Mouse0) && timer < 0)
        {
            GameObject instPrefab = Instantiate(projectile, GetComponent<Transform>().position, GetComponent<Transform>().rotation) as GameObject;
            instPrefab.transform.parent = bucket.transform;
            timer = rof;
        }

        timer -= Time.deltaTime;
    }
}