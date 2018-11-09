using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GeneralManager : MonoBehaviour {
   
    public static Slider counter;
    public float TimeCounter=3;
    public string SceneName;

    public GameObject imag;
    
	// Use this for initialization
	void Start () {
        imag.SetActive(false);

        counter = FindObjectOfType<Slider>();
        if (counter!=null)
        counter.enabled = false;
       
       	}

    // Update is called once per frame
    void Update()
    {
        if (counter.enabled == true && TimeCounter > 0&& counter!=null)
        {
            TimeCounter = TimeCounter - Time.deltaTime;
            counter.value = TimeCounter;

        }
      
    }

   
    public void EnterScene()
    {
        counter.enabled = true;
        StartCoroutine(CountTime());           
    }
    public void PointerExit()
    {
        counter.enabled = false;
        TimeCounter = 3;
        counter.value = 3;
        StopAllCoroutines();
    }
    public void Quit()
    {
        counter.enabled = true;
        StartCoroutine(Exit());
        
    }

    IEnumerator CountTime()
    {
        yield return new WaitForSeconds(3);
        imag.SetActive(true);
        Application.LoadLevel(SceneName);
        
    }
  
    IEnumerator Exit()
    {
        yield return new WaitForSeconds(3);
        Application.Quit();
    }
}
