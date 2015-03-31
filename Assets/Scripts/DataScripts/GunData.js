#pragma strict

class Gun{

	public var ROF : float;
	public var Damage : float;
};

public var currentWeapon : Gun;
private var instObjScript : InstantiateObj;

function Awake(){

	instObjScript = GetComponent.<InstantiateObj>();
}

function Start () {
	
}

function Update () {
	
	instObjScript.spawnRate = currentWeapon.ROF;
}