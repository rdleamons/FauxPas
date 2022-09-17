using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCustom : MonoBehaviour
{
    // Item renderers
    public SpriteRenderer headRenderer;
    public SpriteRenderer bodyRenderer;
    public SpriteRenderer topRenderer;
    public SpriteRenderer bottomRenderer;
    
    // Player object
    public Player player;

    // Arrays of item sprites (player)
    public Sprite[] body;
    public Sprite[] head;
    public Sprite[] skin;

    // Arrays of item sprites (clothes)
    public Sprite[] topTee;
    public Sprite[] topSweater;
    public Sprite[] bottomShort;

    // Change skin color 
    public void changeSkin(int color)
    {
        player.skinColor = color;
        changeBody(player.bodyType);
        changeHead(player.headType);
    }

    // Change head shape
    public void changeHead(int type)
    {
        player.headType = type;

        if (player.skinColor == 0)
            headRenderer.sprite = head[type];
        else if (player.skinColor == 1)
            headRenderer.sprite = head[type + 2];
        else if (player.skinColor == 2)
            headRenderer.sprite = head[type + 4];
    }

    // Change body type 
    public void changeBody(int type)
    {
        player.bodyType = type;

        if (player.skinColor == 0)
            bodyRenderer.sprite = body[type];
        else if (player.skinColor == 1)
            bodyRenderer.sprite = body[type + 2];
        else if (player.skinColor == 2)
            bodyRenderer.sprite = body[type + 4];

        changeBottom(player.bottomType);
        changeTop(player.topType);
    }

    // Change top
    public void changeTop(int topType)
    {
        player.topType = topType;
        if (player.bodyType == 0)
        {
            topRenderer.sprite = topTee[topType];
        }else if (player.bodyType == 1)
        {
            topRenderer.sprite = topTee[topType + 1];
        }
    }

    // Change bottoms
    public void changeBottom(int bottomType)
    {
        player.bottomType = bottomType;

        if(player.bodyType == 0)
        {
            bottomRenderer.sprite = bottomShort[bottomType];
        }else if(player.bodyType == 1)
        {
            bottomRenderer.sprite = bottomShort[bottomType + 1];
        }
    }
}