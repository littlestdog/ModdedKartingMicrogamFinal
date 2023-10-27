using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop : MonoBehaviour
{
    public float Delay = 5.0f;

	// Use this for initialization
	void Start () {
		StartCoroutine(YourFunctionName());
	}
	
	// Update is called once per frame
	void Update () {

	}

	IEnumerator YourFunctionName()
	{
		while(true)
		{
			DoSomething();
			yield return new WaitForSeconds(Delay);
		}
	}

	void DoSomething()
	{
		this.GetComponent<AudioSource>().Play ();
	}
}
