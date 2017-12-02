using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cornelia : MonoBehaviour
{

    public DialogueManager m;
    public DialogueStore store;

    // Use this for initialization
    void Start()
    {
        m = GameObject.FindGameObjectWithTag("DialogueManager").GetComponent<DialogueManager>();
        store = GameObject.FindGameObjectWithTag("DialogueManager").GetComponent<DialogueStore>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        Debug.Log("Stop touching old ladies.");
        m.DialogueStart("Cornelia");
        
        foreach(KeyValuePair<int, string> item in store.Lobby1)
        {
            PleaseSay(store.Lobby1, item.Key);
        }
    }

    private void PleaseSay(SortedDictionary<int, string> d, int key)
    {
        m.Say(d, key);
    }
}


