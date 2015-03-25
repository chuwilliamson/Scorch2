#pragma strict

public var goal : GameObject;
private var navAgent : NavMeshAgent;

function  Awake(){

	navAgent = GetComponent.<NavMeshAgent>();
}

function Start () {

}

function FixedUpdate () {

	navAgent.destination = goal.transform.position;
}