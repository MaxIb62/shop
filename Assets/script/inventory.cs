using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory
{
    public List<item> itemlist;

    public inventory()
    {
        itemlist = new List<item>();

        AddItem(new item { ItemType = item.itemType.weapon, amount = 1 });
        AddItem(new item { ItemType = item.itemType.shield, amount = 1 });
        AddItem(new item { ItemType = item.itemType.hermet, amount = 1 });

        Debug.Log(itemlist.Count);
    }

    public void AddItem(item item)
    {
        itemlist.Add(item);
    }

    public List<item> GetItemList()
    {
        return itemlist;
    }
}

