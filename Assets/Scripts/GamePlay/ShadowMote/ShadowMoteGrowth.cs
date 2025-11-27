using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowMoteGrowth : MonoBehaviour
{
    [SerializeField] float idleGrowth = 0.02f;
    [SerializeField] Vector3 baseScale;
    [SerializeField] Tween growthTween;


    private void Start()
    {
        baseScale = transform.localScale;
    }

    public void StartIdle(float idleTime)
    {
        float growthFactor = 1.0f + (idleTime + idleGrowth);
        Vector3 finalScale = baseScale * growthFactor;

        growthTween?.Kill();
        growthTween = transform.DOScale(finalScale, idleTime).SetEase(Ease.OutSine);

        baseScale = finalScale;

        GetComponent<ShadowMoteEggMovement>()?.MoveToRandomPosition();
    }
}
