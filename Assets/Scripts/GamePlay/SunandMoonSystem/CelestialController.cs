using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CelestialController : MonoBehaviour
{
    [SerializeField] CelestialRotator sunRotator;
    [SerializeField] CelestialRotator moonRotator;
    public bool isSunTurn = false;

    public void SunRotator()
    {
        sunRotator.StartPomodoroRotation();
    }

    public void MoonRotator()
    {
        moonRotator.StartPomodoroRotation();
    }
}
