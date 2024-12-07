using System.ComponentModel;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Scriptable object/Item")]

public class Item : ScriptableObject
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created



    [Header("only gameplay")]
    public TileBase Tile;
    public ItemType type;
    public ActionType actionType;
    public Vector2Int range = new Vector2Int(5, 4);

    [Header("only UI")]
    public bool stackable = true;

    [Header("Both")]
    public Sprite image;
}

public enum ItemType
{
    BuildingBlock,
    Tool

}
public enum ActionType { 
    Digm,
    Mine

}



