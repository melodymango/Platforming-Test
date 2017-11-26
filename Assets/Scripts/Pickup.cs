/*Put on every Pickup prefab (ie every object that can be picked up)*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    public GameObject player;
    public bool canClick;
    public bool isHolding;
    public CircleCollider2D cc;
    public Rigidbody2D rb;
    public BoxCollider2D bc;

    //Make a reference to the player
    //Get all colliders/rigidbodies because we need to disable them if the object gets picked up by the player
    //canClick = whether the player can pick up the item or not
    //isHolding = whether the player is currently holding the item or not
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        cc = this.gameObject.GetComponent<CircleCollider2D>();
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        bc = this.gameObject.GetComponent<BoxCollider2D>();
        canClick = false;
        isHolding = false;
    }

    private void Update()
    {
        //checking if the item isn't being carried by the player
        if (gameObject.transform.parent == null)
        {
            isHolding = false;
            canClick = true;

            //re-enabling colliders & recreating rigidbody so the player will be able to pick the item up again
            cc.enabled = !cc.enabled;
            bc.enabled = !bc.enabled;
            this.gameObject.AddComponent<Rigidbody2D>();
        }
    }

    //Using a CircleCollider2D with a radius slightly bigger than the object itself, so the player can only pick it up if they are within the radius
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "Player")
        {
            canClick = true;
        }
    }

    //What happens when the player clicks on the item
    private void OnMouseDown()
    {
        //code only executes if the player isn't holding anything
        if (canClick)
        {
            //Make the item a child of the player, currently the player is carrying it on their head lol
            gameObject.transform.parent = player.transform;
            gameObject.transform.position = player.transform.position;
            transform.localPosition = new Vector3(0, 0.5f, 0);

            //player can't pick up anymore items because they're holding one
            canClick = false;
            isHolding = true;

            //have to disable colliders and delete the rigidbody because they set off the triggers for the security doors
            //the player should be the only thing setting off the trigger
            cc.enabled = !cc.enabled;
            bc.enabled = !bc.enabled;
            Destroy(rb);
        }
    }
}
