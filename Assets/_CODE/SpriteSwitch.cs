using UnityEngine;
using System.Collections;

public class SpriteSwitch : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    private ChangeViews changeViews;
    public Sprite agentSprite;
    public Sprite origSprite;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        changeViews = GameObject.Find("Main Camera").GetComponent<ChangeViews>();
    }

    void Update()
    {
        if (changeViews.trainerView)
        {
            spriteRenderer.sprite = origSprite;
        }
        if (!changeViews.trainerView)
        {
            spriteRenderer.sprite = agentSprite;
        }
    }
}
