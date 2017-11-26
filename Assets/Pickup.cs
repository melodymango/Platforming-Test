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
        if (gameObject.transform.parent == null)
        {
            isHolding = false;
            canClick = true;
            cc.enabled = !cc.enabled;
            bc.enabled = !bc.enabled;
            this.gameObject.AddComponent<Rigidbody2D>();
        }
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "Player")
        {
            canClick = true;
        }
    }

    private void OnMouseDown()
    {
        if (canClick)
        {
            gameObject.transform.parent = player.transform;
            gameObject.transform.position = player.transform.position;
            transform.localPosition = new Vector3(0, 0.5f, 0);
            canClick = false;
            isHolding = true;
            cc.enabled = !cc.enabled;
            bc.enabled = !bc.enabled;
            Destroy(rb);
        }
    }
}
