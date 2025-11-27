using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowMoteBreath : MonoBehaviour
{
    [SerializeField] float breathSpeed = 1.2f;
    [SerializeField] float breathScale = 1.1f;

    private Vector3 baseScale;
    private Tween breathTween;

    private void Start()
    {
        baseScale = transform.localScale;
        StartBreathing();
    }

    public void StartBreathing()
    {
        breathTween?.Kill();
        breathTween = transform.DOScale(baseScale * breathScale, breathSpeed).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    public void StopBreathing()
    {
        breathTween?.Kill();
    }
}
