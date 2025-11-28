using DG.Tweening;
using UnityEngine;

public class ShadowMoteEggBreath : MonoBehaviour
{
    [SerializeField] float breathSpeed = 1.2f;
    [SerializeField] float breathSize = 1.1f;
    [SerializeField] Tween breathTween; 

    public void StartBreathing()
    {
        StopBreathing();

        Vector3 baseScale = transform.localScale;

        breathTween = transform.DOScale(baseScale * breathSize, breathSpeed)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutSine);
    }

    public void StopBreathing()
    {
        if (breathTween != null && breathTween.IsActive())
        {
            breathTween.Kill();
        }
    }
}
