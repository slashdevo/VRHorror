using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorManager : MonoBehaviour {

    public float counter;
    public Slider timeCounter;
    public bool startCount;
    public MonsterActive m;
    public GameObject arrow;
   
    // public GameObject Monster;


    // Use this for initialization
    void Start () {
       
        arrow = GameObject.FindGameObjectWithTag("Direction");
        m.enabled = false;
        startCount = false;
        timeCounter.value = 3;
        GetComponentInParent<Animator>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		if (startCount && counter>=0)
        {
            counter -= Time.deltaTime;
            
        }
        timeCounter.value = counter;
    }

    IEnumerator CountTime()
    {
        if (transform.localPosition.sqrMagnitude -
            GameObject.FindGameObjectWithTag("MainCamera").transform.localPosition.sqrMagnitude <= 0.25)
        {

            yield return new WaitForSeconds(counter);
            GetComponentInParent<Animator>().enabled = true;
            if (gameObject.tag == "WrongDoor")
            {
                m.enabled = true;
                arrow.SetActive(false);
                StartCoroutine(EndLife());
                //this.enabled = false;
            }
        }
            
    }

    public void StartCount()
    {
      
        startCount = true;
       
        StartCoroutine("CountTime");
    }

    public void StopCount()
    {
       
        counter = 3;
        startCount = false;
       
        StopCoroutine("CountTime");
       // StopAllCoroutines();
    }
    IEnumerator EndLife()
    {
        yield return new WaitForSeconds(2);
        Application.LoadLevel("Death");
    }

}
