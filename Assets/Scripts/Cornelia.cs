using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cornelia : MonoBehaviour {

    public DialogueManager m; 

	// Use this for initialization
	void Start ()
    {
        m = GameObject.FindGameObjectWithTag("DialogueManager").GetComponent<DialogueManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        Debug.Log("Stop touching old ladies.");
        m.DialogueStart("Cornelia");
    }
}
