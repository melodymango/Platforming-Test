using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueStore : MonoBehaviour
{
    public SortedDictionary<int, string> Lobby1; //Ana and Cornelia's coversation when Ana first arrives to the lobby

    // Use this for initialization
    void Start()
    {
        Lobby1 = new SortedDictionary<int, string>();

        Lobby1.Add(1, "Oh! My, my, a new guest, is it?");
        Lobby1.Add(2, "Well, I suppose it’s about time! I expected you to be here hours ago. I swear, that Cabbie gets slower and slower every day.");
    }

}
