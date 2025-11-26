using System.Collections;
using UnityEngine;

public class ShadowMoteManager : MonoBehaviour, IManager
{

    [Header("Prefabs")]
    public GameObject shadowMoteEgg;

    [Header("Setting")]
    public float eggSpawnInterval = 60.0f;

    private bool isRunning = false;

    public void Init()
    {
        isRunning = false;
    }

    public void StartManager()
    {
        if (!isRunning)
        {
            isRunning = true;
            StartCoroutine(SpawnEggEveryMinute());
        }
    }

    private IEnumerator SpawnEggEveryMinute()
    {
        while (true)
        {
            SpawnShadowMoteEgg();
            yield return new WaitForSeconds(eggSpawnInterval);
        }
    }
    private void SpawnShadowMoteEgg()
    {
        Vector2 screenMin = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));
        Vector2 screenMax = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, Camera.main.nearClipPlane));

        Vector2 spawnPos = new Vector2(
            Random.Range(screenMin.x, screenMax.x),
            Random.Range(screenMin.y, screenMax.y)
        );
        Instantiate(shadowMoteEgg, spawnPos, Quaternion.identity);
    }

}
