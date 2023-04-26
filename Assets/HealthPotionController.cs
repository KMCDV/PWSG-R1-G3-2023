using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotionController : MonoBehaviour, IPlayerInteractableOnTrigger
{
    public HealthPotion potionToDrink;
    public GameEvent gameEventToRaiseOnInteraction;

    public void DrinkPotion()
    {
        Debug.Log($"Player is drinking potion with {potionToDrink.health} hp");

        if(gameEventToRaiseOnInteraction != null)
            gameEventToRaiseOnInteraction.FireEvent();
    }

    public void OnPlayerInteract()
    {
        DrinkPotion();
    }
}
