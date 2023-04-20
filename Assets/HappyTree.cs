using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappyTree : MonoBehaviour, IPlayerInteractableOnTrigger
{
    public void ClimbTree()
    {
        Debug.Log("I am changing player script to climb the tree");
    }

    public void OnPlayerInteract()
    {
        ClimbTree();
    }
}
