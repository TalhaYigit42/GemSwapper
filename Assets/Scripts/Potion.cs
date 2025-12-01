using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion: MonoBehaviour
{

public PotionType potionType;
 public int xindex;
 public int yindex;   

 public bool isMatched;
 private Vector2 CurrentPos;
 private Vector2 targetPos;

 public bool isMoving;

 public Potion(int _x, int _y)
    {
        xindex=_x;
        yindex=_y;
    }
public void SetIndecies(int _x, int _y)
    {
        xindex=_x;
        yindex=_y;
    }


public enum PotionType
    {
        Red,
        Blue,
        Purple,
        Green,
        White
    }


}
