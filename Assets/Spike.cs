using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour, IPlayerInteractableOnTrigger
{
    public void KillPlayer()
    {
        Debug.Log("I am killing the player");
    }

    public void OnPlayerInteract()
    {
        KillPlayer();
    }
}
