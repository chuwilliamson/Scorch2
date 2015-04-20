using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour {

	public GameObject levelPortal;
	public GameObject MoveOn;
	public int LevelCounter = 1;
	void Start () {
		levelPortal.SetActive (false);
	}
	public void OnTriggerEnter(Collider other){
		MoveOn.SetActive(true);
	}
	public void OnTriggerExit(Collider other){
		MoveOn.SetActive(false);
	}
	void Update () {
        if (MoveOn.activeInHierarchy){

            if (Input.GetKeyDown(KeyCode.E))
            {
                int num;
                num = Random.Range(1, 4);

                Application.LoadLevel(Random.Range(num, Application.levelCount -1));
				LevelCounter++;
				Debug.Log (LevelCounter);
            }
        }
	}
}
