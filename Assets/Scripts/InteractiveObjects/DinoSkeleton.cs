using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoSkeleton : MonoBehaviour
{
    public Equipment eq;

    private void OnMouseDown()
    {
        if (eq.items[2] != null && eq.items[2].GetIsSelected() && eq.items[2].gameObject.GetComponent<SpriteRenderer>().sprite.name == "latarka-charged")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Interacive/dino-skeleton-uncovered"); // uncover the truth
            eq.items[2].ChangeIsSelectedStatus(); // unselect uv light
        }
    }
}
