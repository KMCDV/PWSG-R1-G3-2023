using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Super Kwadrat/PlayerSpeed")]
public class GameEvent : ScriptableObject
{
    
    public List<IGameEventListener> listenersList = new List<IGameEventListener>();

    public void FireEvent()
    {
        for (int i = 0; i < listenersList.Count; i++)
        {
            listenersList[i].Notify();
        }
    }

    public void RegisterListener()
    {
        listenersList.Add(null);
    }

    public void UnregisterListener()
    {

    }

}