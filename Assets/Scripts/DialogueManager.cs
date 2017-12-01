using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour {

    public GameObject player;
    public DemoScene movement;
    public Transform speech;

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
        //GameObject speechbubble = Instantiate(speech, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        Instantiate(speech, new Vector3(0, 0, 0), Quaternion.identity);
        //speechbubble.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
    }

    
}
