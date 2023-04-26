using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthPotionNotification : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void DisplayPotionText()
    {
        StartCoroutine(DisplayTextFor2Seconds());
    }

    IEnumerator DisplayTextFor2Seconds()
    {
        text.text = "I picked up a potion";
        yield return new WaitForSecondsRealtime(2f);
        text.text = "";
    }
}
