using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Security : MonoBehaviour {

    public bool isHold;
    public GameObject doors;

    // Use this for initialization
    void Start () {
        isHold = false;
        doors = GameObject.FindGameObjectWithTag("Door");
	}


	
    public void TriggerEnter(Collider2D c)
    {
        if (c.gameObject.tag == "Player" && c.gameObject.transform.childCount > 0)
        {
            Pickup pscript = c.gameObject.GetComponentInChildren<Pickup>();
            isHold = pscript.isHolding;
            if (isHold)
            {
                Debug.Log("is hold!!!");
            }
        }
    }

    public void TriggerExit(Collider2D c)
    {
        if (isHold)
        {
            foreach (Transform door in doors.transform)
            {
                //Debug.Log(door.transform.position);
                if (door.gameObject.activeInHierarchy)
                {
                    door.gameObject.SetActive(false);
                }
                else
                {
                    door.gameObject.SetActive(true);
                }
            }
        }
    }
}
