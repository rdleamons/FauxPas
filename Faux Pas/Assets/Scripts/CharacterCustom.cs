using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCustom : MonoBehaviour
{
    //public GameObject player;
    public SpriteRenderer headRenderer;
    public SpriteRenderer bodyRenderer;
    public SpriteRenderer topRenderer;
    public SpriteRenderer bottomRenderer;
    public Player player;

    public Sprite[] body;
    public Sprite[] topTee;
    public Sprite[] topSweater;
    public Sprite[] bottomShort;
    public Sprite[] bottomLong;

    public void changeHead(Sprite head)
    {
        //player.SpriteRenderer.sprite = head;
        headRenderer.sprite =  head;
    }

    public void changeBody(int type)
    {
        bodyRenderer.sprite = body[type];
        player.bodyType = type;

        changeTop(type);
    }

    public void changeTop(int topType)
    {
        if(topType == 0) // If top is a tee shirt
        {
            if (player.bodyType == 0)
            {
                topRenderer.sprite = topTee[0];
            }
            else if (player.bodyType == 1)
            {
                topRenderer.sprite = topTee[1];
            }
            else if (player.bodyType == 2)
            {
                topRenderer.sprite = topTee[2];
            }
        }else if(topType == 1) // If top is a sweater
        {
            if (player.bodyType == 0)
            {
                topRenderer.sprite = topSweater[0];
            }
            else if (player.bodyType == 1)
            {
                topRenderer.sprite = topSweater[1];
            }
            else if (player.bodyType == 2)
            {
                topRenderer.sprite = topSweater[2];
            }
        }
        
    }

    public void changeBottom(int bottomType)
    {
        if(bottomType == 0) // If bottoms are shorts
        {
            if (player.bodyType == 0)
            {
                topRenderer.sprite = bottomShort[0];
            }
            else if (player.bodyType == 1)
            {
                topRenderer.sprite = bottomShort[1];
            }
            else if (player.bodyType == 2)
            {
                topRenderer.sprite = bottomShort[2];
            }
        } else if(bottomType == 1) // If bottoms are long
        {
            if (player.bodyType == 0)
            {
                topRenderer.sprite = bottomLong[0];
            }
            else if (player.bodyType == 1)
            {
                topRenderer.sprite = bottomLong[1];
            }
            else if (player.bodyType == 2)
            {
                topRenderer.sprite = bottomLong[2];
            }
        }
        
    }
}
