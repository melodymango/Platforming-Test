using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueStore : MonoBehaviour
{

    public SortedDictionary<int, string> Lobby1; //Ana and Cornelia's coversation when Ana first arrives to the lobby

    // Use this for initialization
    void Start()
    {
        Lobby1.Add(1, "Kw...kwibbit?");
    }

}
