using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine.UI;
public enum ScreenType
{
    Panel,
    InfoPanel,
    Shop
}

public class ScreenBase : MonoBehaviour
{
    public ScreenType screenType;

    public List<Transform> listOfObjects;
    public List<TextAnimation> listOfPhrases;

    public Image uiBackground;

    public bool startHided = false;

    [Header("Animation")]
    public float delayBetweenObjects = 0.5f;
    public float animationDuration = 0.2f;

    void Start()
    {
        if(startHided)
        {
            HideObjects();
        }
    }

    [Button]

    public virtual void Show()
    {
        ShowObjects();
    }

    [Button]

    public virtual void Hide()
    {
        HideObjects();
    }

    private void HideObjects()
    {
        listOfObjects.ForEach(i => i.gameObject.SetActive(false));
        uiBackground.enabled = false;
    }

    private void ShowObjects()
    {
        for(int i = 0; i < listOfObjects.Count; i++)
        {
            var obj = listOfObjects[i];

            obj.gameObject.SetActive(true);
            obj.DOScale(0, animationDuration).From().SetDelay(i * delayBetweenObjects);
        }

        uiBackground.enabled = true;

    }

} 
