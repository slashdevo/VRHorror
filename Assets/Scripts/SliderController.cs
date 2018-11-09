using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderController : MonoBehaviour {
    
    // Use this for initialization
    IEnumerator Start () {
        yield return new WaitForSeconds(103);
        Application.LoadLevel("StartScene");
    }
	
	// Update is called once per frame
	void Update () {
      
        }
    }

