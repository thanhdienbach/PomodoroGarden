using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayUI : MonoBehaviour
{
    [SerializeField] Button nextCycleButton;
    [SerializeField] CelestialController celestialController;

    public void NextButtonEvent()
    {
        if (celestialController.isSunTurn)
        {
            celestialController.MoonRotator();
        }
        else
        {
            celestialController.SunRotator();
        }
        celestialController.isSunTurn = !celestialController.isSunTurn;
        nextCycleButton.gameObject.SetActive(false);
    }
}
