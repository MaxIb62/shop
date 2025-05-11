using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item
{
   public enum itemType
    {
        weapon,
        shield,
        hermet,
    }

    public itemType ItemType;
    public int amount;
}
