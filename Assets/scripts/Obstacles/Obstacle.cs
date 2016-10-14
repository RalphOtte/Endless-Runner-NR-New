using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

    private float moveSpeed;

    [SerializeField]private float minSpeed;
    [SerializeField]private float maxSpeed;
    [SerializeField]private int damage;
    [SerializeField]private float lifetime;

    public PlayerData player;

    void Awake()
    {
        DetermineSpeed();
        WhatSideAmI(); //Check which side the player is
        Debug.Log("What side am i?");
        Destroy(this.gameObject, lifetime);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Player")
        {
            Debug.Log(player.Health);
            player.Health -= damage;
            Debug.Log(player.Health);
            Destroy(this.gameObject);
        }
    }

    void DetermineSpeed()
    {
        moveSpeed = Random.Range(minSpeed, maxSpeed);
    }

    void WhatSideAmI()
    {
        if (this.transform.position.x >= player.transform.position.x)   //Replace "player.transform.position.x" with "player.xPos"
        {
            moveLeft();
            SwitchScale();
        }
        else
        {
            moveRight();
        }
    }

    void SwitchScale()
    {
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }

    void moveLeft()
    {
        transform.position -= transform.right * Time.deltaTime * moveSpeed;
        Invoke("moveLeft", 0.0f);
    }

    void moveRight()
    {
        transform.position += transform.right * Time.deltaTime * moveSpeed;
        Invoke("moveRight", 0.0f);
    }


}
