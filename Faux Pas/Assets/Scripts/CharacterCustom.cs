using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCustom : MonoBehaviour
{
    // Item renderers
    public SpriteRenderer headRenderer;
    public SpriteRenderer hairRenderer;
    public SpriteRenderer hairFrontRenderer;
    public SpriteRenderer hatFrontRenderer;
    public SpriteRenderer eyebrowRenderer;
    public SpriteRenderer bodyRenderer;
    public SpriteRenderer eyeRenderer;
    public SpriteRenderer eyeColorRenderer;
    public SpriteRenderer noseRenderer;
    public SpriteRenderer mouthRenderer;
    public SpriteRenderer topRenderer;
    public SpriteRenderer bottomRenderer;
    public SpriteRenderer shoeRenderer;
    public SpriteRenderer underwearRenderer;
    
    // Player object
    public Player player;

    // Arrays of item sprites (player)
    public Sprite[] body;
    public Sprite[] head;
    public Sprite[] skin;
    public Sprite[] nose;
    public Sprite[] mouth;
    public Sprite[] hair;
    public Sprite[] hairFront;
    public Sprite[] hat;
    public Sprite[] eyes;
    public Sprite[] eyeColor;
    public Sprite[] eyebrow;

    // Arrays of item sprites (clothes)
    public Sprite[] topTee;
    public Sprite[] topSweater;
    public Sprite[] bottomShort;
    public Sprite[] shoes;
    public Sprite[] underwear;

    // Change skin color 
    public void changeSkin(int color)
    {
        player.skinColor = color;

        changeBody(player.bodyType);
        changeHead(player.headType);
        changeNose(player.noseType);
    }

    public void changeEyeColor(int color)
    {
        player.eyeColor = color;
        eyeColorRenderer.sprite = eyeColor[color];
    }

    public void changeHairColor(int color)
    {
        player.hairColor = color;
        player.eyebrowType = color;

        eyebrowRenderer.sprite = eyebrow[color];
        changeHair(player.hairStyle);
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

    // Change nose type
    public void changeNose(int type)
    {
        player.noseType = type;

        if (player.skinColor == 0)
            noseRenderer.sprite = nose[type];
        else if (player.skinColor == 1)
            noseRenderer.sprite = nose[type + 1];
        else if (player.skinColor == 2)
            noseRenderer.sprite = nose[type + 2];
    }

    // Change shoes
    public void changeMouth(int style)
    {
        player.mouthType = style;
        mouthRenderer.sprite = mouth[style];
    }

    // Change body type 
    public void changeBody(int type)
    {
        // Update body type int
        player.bodyType = type;

        // Update underwear
        underwearRenderer.sprite = underwear[type];

        // Update body based on skin tone
        if (player.skinColor == 0)
            bodyRenderer.sprite = body[type];
        else if (player.skinColor == 1)
            bodyRenderer.sprite = body[type + 2];
        else if (player.skinColor == 2)
            bodyRenderer.sprite = body[type + 4];

        // Update clothing
        changeBottom(player.bottomType);
        changeTop(player.topType);
    }

    // Change hair color and style
    public void changeHair(int style)
    {
        player.hairStyle = style;

        if (player.hairColor == 0)
        {
            hairRenderer.sprite = hair[style];
            hairFrontRenderer.sprite = hairFront[style];
        }else if (player.hairColor == 1)
        {
            hairRenderer.sprite = hair[style + 3];
            hairFrontRenderer.sprite = hairFront[style + 3];
        }
        else if (player.hairColor == 2)
        {
            hairRenderer.sprite = hair[style + 6];
            hairFrontRenderer.sprite = hairFront[style + 6];
        }
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
    
    // Change shoes
    public void changeShoes(int style)
    {
        player.shoeType = style;
        shoeRenderer.sprite = shoes[style];
    }

    // Change hat
    public void changeHat(int style)
    {
        player.hatType = style;
        hatFrontRenderer.sprite = hat[style];
    }

    // Tuck shirt into pants
    public void tuckShirt()
    {
        if(topRenderer.sortingOrder > bottomRenderer.sortingOrder)
        {
            topRenderer.sortingOrder = topRenderer.sortingOrder - 1;
            bottomRenderer.sortingOrder = bottomRenderer.sortingOrder + 1;
        }else if(topRenderer.sortingOrder < bottomRenderer.sortingOrder)
        {
            topRenderer.sortingOrder = topRenderer.sortingOrder + 1;
            bottomRenderer.sortingOrder = bottomRenderer.sortingOrder - 1;
        }
    }
}
