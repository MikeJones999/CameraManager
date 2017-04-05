using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour {

	private GameObject weapon;

	// Use this for initialization
	void Start () {
		weapon = transform.gameObject;
		Debug.Log("weapon - " + weapon);
			
			//GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnMouseDown()
	{
		CameraManager.instance.FocusMe(weapon);
	}

}
