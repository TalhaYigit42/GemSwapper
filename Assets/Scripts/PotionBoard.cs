using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionBoard: MonoBehaviour
{
    public int width=7;
    public int height=9;
    public float spacingX;
    public float spacingY;
    public GameObject[] potionPrefabs;
    private Node[,] portionBoard;
    public GameObject potionBoardGo;

    public ArrayLayout arrayLayout;
    public static PotionBoard Instance;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {

    }
    
    void InitializeBoard()
    {
        potionBoardGo = new Node[width, height];
        spacingX= (float)(width-1)/2;
        spacingY=(float)(height-1)/2;

        for(int x = 0; x<width; x++)
        {
            Vector2 position =new Vector2(x-spacingX,spacingY-spacingY);
            int randomIndex = randomIndex.Range(0, poionPrefabs.Length);
            GameObject potion = Instantiate(potionPrefabs[randomIndex], position,Quaternion.identity);
            potion.GetComponent<Potion>().SerIndecies(x,y);
            potionBoardGo[x.y]=new Node(true,potion);
        }
    }
}
