using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CelestialRotator : MonoBehaviour
{
    [Header("Config")]
    public float startAngle = 30.0f;
    public float endAngle = -30.0f;
    public float pomodoroTimer = 1500.0f;
    public Button nextCycleButton;

    Tween rotateTween;

    public void StartPomodoroRotation()
    {
        if (rotateTween == null && rotateTween.IsActive())
        {
            rotateTween.Kill();
        }

        transform.rotation = Quaternion.Euler(0,0,startAngle);

        rotateTween = transform
            .DORotate(new Vector3(0, 0, endAngle), pomodoroTimer, RotateMode.Fast)
            .SetEase(Ease.Linear)
            .OnComplete(() =>
            {
                transform.rotation = Quaternion .Euler(0,0,startAngle);
                nextCycleButton.gameObject.SetActive(true);
            }
            );
    }

    public void StopRotator()
    {
        if ( rotateTween == null && rotateTween.IsActive())
        {
            rotateTween.Kill();
        }
    }
}
