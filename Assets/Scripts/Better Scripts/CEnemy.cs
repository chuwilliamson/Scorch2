using UnityEngine;
using System.Collections;

// attach to enemy prefab

public class CEnemy : MonoBehaviour {

    public float armor;
    public float speed;
    public float attackDamage;

    [SerializeField]
    private float armorRange;
    [SerializeField]
    private float speedRange;
    [SerializeField]
    private float attackRange;
    private NavMeshAgent agentComp;

	// Use this for initialization
	void Start () {

        agentComp = GetComponent<NavMeshAgent>();
        attackDamage = Random.Range(1, attackRange);
        armor = Random.Range(0, armorRange);
        speed = Random.Range(1, speedRange);
        agentComp.speed = speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
