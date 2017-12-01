using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour {

    public GameObject player;
    public DemoScene movement;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        movement = player.GetComponent<DemoScene>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DialogueStart(string name)
    {
        Debug.Log("Dialogue started with " + name);
        movement.canMove = false;
    }

    
}
