using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBarTest : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public Material healthMaterial;
    public Material dissolveMaterial;
    public string PropertyName;

    public float GreenValue = 1;
    public float YellowValue = 0.5f;
    public float RedValue = 0;

    float health, maxHealth = 100;

    private float MixValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health + "%";
        if (health > maxHealth)
        {
            health = maxHealth;
        }

        ColorChanger();
        Dissolve();
    }

    public void Damage(float damagePoints)
    {
        if (health > 0)
        {
            health -= damagePoints;
        }
    }

    public void Heal(float healingPoints)
    {
        if (health < maxHealth)
        {
            health += healingPoints;
        }
    }

    public void ColorChanger()
    {
        healthMaterial.SetFloat(PropertyName, MixValue);

        MixValue = health / maxHealth;
       
    }

    public void Dissolve()
    {
        dissolveMaterial.SetFloat(PropertyName, MixValue);

        MixValue = health / maxHealth;
    }
}
