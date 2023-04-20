using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, IPlayerInteractableOnTrigger
{

    public HealthPotion potionToDrink;

    public void DrinkPotion()
    {
        Debug.Log($"Player is drinking potion with {potionToDrink.health} hp");
    }

    public void OnPlayerInteract()
    {
        DrinkPotion();
    }
}
