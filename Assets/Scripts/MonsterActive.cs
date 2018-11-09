using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterActive : MonoBehaviour {
  
   // public GameObject Monster;
	// Use this for initialization
	void Start () {
           GetComponent<Animator>().enabled = true;
           GetComponent<AudioSource>().Play();
       
    }
	
	// Update is called once per frame
	void Update () {
       
	}

   /* void OnTriggerEnter(Collider col)
    {
        if (col.tag=="MainCamera")
        {
           
            
                GetComponent<Animator>().enabled = true;
                GetComponent<AudioSource>().Play();
            
        }
    }*/

  /*  IEnumerator Manage()
    {
        yield return new WaitForSeconds();
    }*/
}
