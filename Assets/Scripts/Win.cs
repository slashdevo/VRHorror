using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {
    public string level;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  public  void Load( )
    {
        //if (col.gameObject.tag=="MainCamera")
        //{
            Application.LoadLevel(level);
       // }
    }
}
