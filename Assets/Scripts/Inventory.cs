using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool inventoryEnabled;
    public GameObject inventory;

    private int allSlots;
    private GameObject[] slot;

    public GameObject slotHolder;

    void Start() 
    {
        allSlots = 12;
        slot = new GameObject[allSlots];

        for(int i = 0; i < allSlots; i++) 
        {
            slot[i] = slotHolder.transform.GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
            inventoryEnabled = !inventoryEnabled;

        if(inventoryEnabled == true) 
        {
            inventory.SetActive(true);
        } else 
        {
            inventory.SetActive(false);
        }
    }
}
