using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

    public static CameraManager instance;
    public GameObject cameraDefault;



    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void DefaultPosition()
    {
        Camera.main.transform.position = cameraDefault.transform.position;
        Camera.main.transform.rotation = cameraDefault.transform.rotation;
    }

    public void FocusMe(GameObject weapon)
    {
        var pos = weapon.transform.position;

        var offset = new Vector3(pos.x -8, pos.y +1, pos.z -5);

        Camera.main.transform.position = offset;
        Camera.main.transform.LookAt(pos);

    }


    // Use this for initialization
    void Start () {


        Camera.main.transform.position = cameraDefault.transform.position;
       // Camera.main.transform.rotation = cameraDefault.transform.rotation;


    }

    // Update is called once per frame
    void Update () {
		
	}
}
