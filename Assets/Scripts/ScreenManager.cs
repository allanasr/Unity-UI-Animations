using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Singleton;

public class ScreenManager : Singleton<ScreenManager>
{
    public List<ScreenBase> screenBases;

    private ScreenType startScreen = ScreenType.Panel;

    private ScreenBase currentScreen;

    private void Start()
    {
        HideAll();
        ShowByType(startScreen);
    }

    public void ShowByType(ScreenType type)
    {
        if (currentScreen != null) currentScreen.Hide();

        var nextScreen = screenBases.Find(i => i.screenType == type);

        nextScreen.Show();
        currentScreen = nextScreen;
    }

    public void HideAll()
    {
        screenBases.ForEach(i => i.Hide());
    }
}
