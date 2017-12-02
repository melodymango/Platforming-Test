using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public GameObject player;
    public GameObject npc;
    public DemoScene movement;
    public Transform speech_transform;
    public Transform speech_prefab;

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
        //Find which NPC the player just clicked on
        GetNPC(name);

        //Disable player movement when dialogue starts
        movement.canMove = false;

    }

    public void Say(SortedDictionary<int,string> d, int key)
    {
        CreateSpeechBubble();
        speech_transform.gameObject.GetComponentInChildren<Text>().text = d[key];
    }

    public void GetNPC(string name)
    {
        npc = GameObject.FindGameObjectWithTag(name);
        Debug.Log("Dialogue started with " + name);
    }

    //Instantiate speech bubble on NPC and change position to be on top of NPC
    public void CreateSpeechBubble()
    {
        speech_transform = Instantiate(speech_prefab, new Vector3(0, 0, 0), Quaternion.identity);
        speech_transform.SetParent(GameObject.FindGameObjectWithTag("Dialogue Canvas").transform, false);
        speech_transform.position = new Vector3(npc.transform.position.x, npc.transform.position.y + 2.5f, npc.transform.position.z);
    }
}

