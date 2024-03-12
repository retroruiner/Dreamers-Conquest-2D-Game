using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Inventory;

[CreateAssetMenu]
public class Weapon : Item
{
    [field: SerializeField]
    public Damage damage { get; set; } = Damage.HandDamage();
    public Weapon() 
    {}
    public Weapon(Damage damage) 
    {
        this.damage = damage;
    }
    
    public override Damage dealDamage()
    {
        Debug.Log("Weapon");
        return damage;
    }

    [System.Serializable]
    public class Damage
    {
        public float Amount { get; set; }
        public float Knock { get; set; }
        public DamageTypes DamageType { get; set; }
        public static Damage HandDamage()
            => new Damage
            {
                Amount = 0.2f,
                Knock = 0,
                DamageType = DamageTypes.Physical
            };
    }
}