using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Super Kwadrat/Game Event")]
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

    public void RegisterListener(IGameEventListener gameEventListener)
    {
        if (listenersList == null)
            return;

        if (listenersList.Contains(gameEventListener))
            return;

        listenersList.Add(gameEventListener);
    }

    public void UnregisterListener(IGameEventListener gameEventListener)
    {
        if (listenersList == null)
            return;

        if (listenersList.Contains(gameEventListener) == false)
            return;

        listenersList.Remove(gameEventListener);
    }

}