using System;
using UnityEngine;

public class InventoryItemBaseData : ScriptableObject
{
    public string id;
    public string name;
    public E_InventoryItemBase itemBaseType;
    public Sprite sprite;

#if UNITY_EDITOR
    protected virtual void OnValidate()
    {
        if (id == "0" || string.IsNullOrEmpty(id))
        {
            id = Guid.NewGuid().ToString();
        }
    }
#endif
}