using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using V_AnimationSystem;

public class SpriteChange : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Sprite newSprite2;
    public Sprite oldSprite;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            spriteRenderer.sprite = newSprite;
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            spriteRenderer.sprite = newSprite2;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.LeftControl))
        {
            spriteRenderer.sprite = oldSprite;
        }
    }
}