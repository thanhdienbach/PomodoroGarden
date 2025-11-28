using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowMoteEggHatch : MonoBehaviour
{
    [SerializeField] GameObject shadowMoteEgg;
    [SerializeField] GameObject shadowMote;

    public void Hatch()
    {
        float r = Random.value;

        if (r < 0.7)
        {
            Instantiate(shadowMoteEgg, transform.position, Quaternion.identity);
        }
        else
        {
            Instantiate(shadowMote, transform.position, Quaternion.identity);
        }

        Destroy(gameObject);
    }
}
