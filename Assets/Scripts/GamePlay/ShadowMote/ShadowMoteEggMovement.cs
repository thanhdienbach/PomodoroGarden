using DG.Tweening;
using UnityEngine;

public class ShadowMoteEggMovement : MonoBehaviour
{


    public float minMoveDuration = 12.0f;
    public float maxMoveDuration = 18.0f;
    public float minIdle = 4.0f;
    public float maxIdle = 8.0f;
    public float padding = 0.1f;

    private Camera mainCamera;
    private Tween moveTween;


    private ShadowMoteGrowth shadowMoteGrowth;

    private void Start()
    {
        mainCamera = Camera.main;
        shadowMoteGrowth = GetComponent<ShadowMoteGrowth>();

        MoveToRandomPosition();
    }

    public void MoveToRandomPosition()
    {
        Vector2 targetPosition = GetRandomPositionInsideCamera();
        float moveDuration = Random.Range(minMoveDuration, maxMoveDuration);

        moveTween = transform.DOMove(targetPosition, moveDuration).SetEase(Ease.InOutSine).OnComplete
        (
            () =>
            {
                float idleTime = Random.Range(minIdle, maxIdle);
                shadowMoteGrowth?.StartIdle(idleTime);
            }
        );
    }
    private Vector2 GetRandomPositionInsideCamera()
    {
        float vx = Random.Range(0 + padding, 1f - padding);
        float vy = Random.Range(0 + padding, 1f - padding);

        Vector3 worldPosition = mainCamera.ViewportToWorldPoint(new Vector3(vx, vy, 0));
        worldPosition.z = 0;

        return worldPosition;
    }
}
