using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotDisplay : MonoBehaviour
{
    public Item item;
    public Text nameText;
    public Text descriptionText;
    public Text damageText;
    public Text durabilityText;
    public Image artworkImage;
    
    void Update()
    {
        item.Print();
        nameText.text = "Name: " + item.name;
        descriptionText.text = "Description: " + item.description;

        artworkImage.sprite = item.icon;
        damageText.text = "Damage: " + item.damage;
        durabilityText.text = item.durability.ToString();
    }
}
