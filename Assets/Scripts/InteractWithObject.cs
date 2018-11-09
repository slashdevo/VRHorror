using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithObject : MonoBehaviour {
    
    public GameObject cam;
    public GameObject CamParet;
    public bool lockmove;
    public float speed;
    public Vector3 temp;
    public Vector3 move;
    public Material fade;
    public Material non_fade;
    public AudioSource footsteps;
   

	// Use this for initialization
	void Start () {
       
        lockmove = false;
        temp = cam.transform.rotation.eulerAngles;
        gameObject.GetComponent<MeshRenderer>().material = non_fade;
	}
	
	// Update is called once per frame
	void Update () {
        cam.transform.localPosition = new Vector3(cam.transform.localPosition.x, -0.8f, cam.transform.localPosition.z);
       gameObject.transform.position = cam.transform.position + move;
        if (lockmove)
        {
            cam.transform.position += transform.forward*speed*Time.deltaTime;
            
        }

     if (temp==cam.transform.rotation.eulerAngles)
        {
            
        }
     else
        {
            gameObject.transform.rotation = cam.transform.rotation;
            temp = cam.transform.rotation.eulerAngles;
        }

       
    }

    public void MoveForward()
    {
        lockmove = true;
        gameObject.GetComponent<MeshRenderer>().material = fade;
        footsteps.Play();
        CamParet.GetComponent<Animator>().speed = 1f;
    }

    public void StopMoving()
    {
        lockmove = false;
        gameObject.GetComponent<MeshRenderer>().material = non_fade;
        footsteps.Pause();
        CamParet.GetComponent<Animator>().speed = 0;
    }
}
