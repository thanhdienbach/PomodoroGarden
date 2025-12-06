using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputRaycaster : MonoBehaviour
{

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(worldPos, Vector2.zero);

            if (hit.collider != null)
            {
                PlantSlot slot = hit.collider.GetComponent<PlantSlot>();
                if (slot != null)
                {
                    slot.OnSlotClicked();
                }
            }
        }
    }
}
