using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthPotionNotification : MonoBehaviour
{
    public TextMeshProUGUI text;
    public HealthPotion healthPotionController;

    public void DisplayPotionText()
    {
        StartCoroutine(DisplayTextFor2Seconds());
    }

    IEnumerator DisplayTextFor2Seconds()
    {
        text.text = $"I picked up a potion with {healthPotionController.health}";
        yield return new WaitForSecondsRealtime(2f);
        text.text = "";
    }
}
