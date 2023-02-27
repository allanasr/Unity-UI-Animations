using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;
public class ButtonScaler : MonoBehaviour, IPointerEnterHandler , IPointerExitHandler
{
    public float defaultScale = 1f;
    public float finalScale = 1.2f;
    public float scaleDuration = 0.3f;
    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.DOScale(finalScale, scaleDuration);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOKill();
        transform.DOScale(defaultScale, scaleDuration);
    }
}
