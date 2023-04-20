using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMoveScript : MonoBehaviour
{
    public float speed;
    public Rigidbody body;

    public HealthPotion potionToDrink;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector3(Input.GetAxis("Vertical")  * speed, 0f,Input.GetAxis("Horizontal") * speed);

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log($"I am drinking {potionToDrink.health} hp");
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        IPlayerInteractableOnTrigger playerInteractableOnTrigger = other.GetComponent<IPlayerInteractableOnTrigger>();
        if (playerInteractableOnTrigger != null)
        {
            playerInteractableOnTrigger.OnPlayerInteract();
        }
    }
}
