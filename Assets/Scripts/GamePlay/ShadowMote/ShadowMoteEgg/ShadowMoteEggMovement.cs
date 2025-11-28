using DG.Tweening;
using UnityEngine;

public class ShadowMoteEggMovement : MonoBehaviour
{
    public float minMoveDuration = 12.0f;
    public float maxMoveDuration = 18.0f;
    public float padding = 0.1f;

    private Camera mainCamera;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    public void StartMovement(System.Action onComplete)
    {
        Vector2 target = GetRandomPoint();
        float duration = Random.Range(minMoveDuration, maxMoveDuration);

        transform.DOMove(target, duration)
            .SetEase(Ease.InOutSine)
            .OnComplete
            (
                 () =>
                 {
                     onComplete.Invoke();
                 } 
                 
            )
            ;
    }
    private Vector3 GetRandomPoint()
    {
        float x = Random.Range(padding, 1.0f - padding);
        float y = Random.Range(padding, 1.0f - padding);

        Vector3 position = mainCamera.ViewportToWorldPoint(new Vector3(x, y, 0));
        position.z = 0;

        return position;
    }
}
