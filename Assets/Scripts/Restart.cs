using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {
    public float n;
	// Use this for initialization
	IEnumerator Start () {
        yield return new WaitForSeconds(n);
        Application.LoadLevel("StartScene");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
}
