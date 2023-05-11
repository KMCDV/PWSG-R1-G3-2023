using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

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
        transform.DOScale(1.1f, 1f).SetLoops(2, LoopType.Yoyo);
        text.text = $"I picked up a potion with {healthPotionController.health}";
        yield return new WaitForSecondsRealtime(2f);
        text.text = "";
    }
}
