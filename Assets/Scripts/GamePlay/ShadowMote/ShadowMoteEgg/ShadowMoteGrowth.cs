using DG.Tweening;
using UnityEngine;

public class ShadowMoteGrowth : MonoBehaviour
{
    [SerializeField] float idleGrowthRate = 0.02f;
    [SerializeField] float minIdle = 4.0f;
    [SerializeField] float maxIdle = 8.0f;
    [SerializeField] Tween growthTween;

    public void StartGrowth(System.Action<float> onComplete)
    {
        StopGrowth();

        float idleTime = Random.Range(minIdle, maxIdle);
        float growthFactor = 1f + idleTime * idleGrowthRate;

        Vector3 newScale = transform.localScale * growthFactor;

        growthTween = transform.DOScale(newScale, idleTime)
            .SetEase(Ease.OutSine)
            .OnComplete(() =>
            {
                onComplete?.Invoke(transform.localScale.x);
            });
    }
    public void StopGrowth()
    {
        if (growthTween != null && growthTween.IsActive())
        {
            growthTween.Kill();
        }
    }
}
