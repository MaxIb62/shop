using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Inventory : MonoBehaviour
{
    private inventory Invemtory;
    private Transform itemSlotCont;
    private Transform itemSlotTemplt;

    private void Awake()
    {
        itemSlotCont = transform.Find("itemSlotContainer");
        itemSlotTemplt = itemSlotCont.Find("slot");
    }
    public void SetInventory(inventory inventory)
    {
        this.Invemtory = inventory;
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems()
    {
        foreach (item Item in Invemtory.GetItemList())
        {

            int x =0;
            int y = 0;
            float itemSlotCellSize = 30f;
            RectTransform itemslotrectransform = Instantiate (itemSlotTemplt, itemSlotCont).GetComponent<RectTransform>();
            itemslotrectransform.gameObject.SetActive(true);
            itemslotrectransform.anchoredPosition = new Vector2 (x * itemSlotCellSize, -y * itemSlotCellSize);
            x++;
            if (x>4)
            {
                x = 0;
                y++;
            }
        }
    }
}
