using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonData : MonoBehaviour
{
    [SerializeField] private string name = "Gengar";
    [SerializeField] private int life = 60;
    private int current_life = 60;
    private int sSatsPoints = 0;
    [SerializeField] private int attack = 65;
    [SerializeField] private int defense = 60;
    [SerializeField] private float weight = 40.5f;
    [SerializeField] private enum types
    {
        Bug,
        Dark,
        Dragon,
        Electric,
        Fairy,
        Fighting,
        Fire,
        Flying,
        Ghost,
        Grass,
        Ground,
        Ice,
        Normal,
        Poison,
        Psychic,
        Rock,
        Steel,
        Water
    }

    [SerializeField] private types _Types;

    [SerializeField] string[] weaknesses = { "Psychic", "Ground", "Ghost", "Dark" };
    [SerializeField] string[] resistance = { "Fairy", "Bug", "Grass", "Poison" };

    void Start()
    {
        int PokemonLife = current_life;
        int StatsPoints = attack + defense + life;
        int GetAttackDamage = attack;

            int damage = 20;
            string TypePokemon = weaknesses[0];

            if (TypePokemon == weaknesses[0] || TypePokemon == weaknesses[1] || TypePokemon == weaknesses[2] || TypePokemon == weaknesses[3])
            {
                damage *= 2;
            }
            else if (TypePokemon == resistance[0] || TypePokemon == resistance[1] || TypePokemon == resistance[2] || TypePokemon == resistance[3])
            {
                damage /= 2;
            }
            else if (damage <= 0)
            {
                damage = 0;
            }
            else
            {
                damage = 20;
            }


        Debug.Log("The name of the Pokemon is : " + name);
        Debug.Log("Gengar has : " + life + " health points.");
        Debug.Log("The value of attack of Gengar is : " + attack + " of damage.");
        Debug.Log("The value of defense of Gengar is : " + defense + ".");
        Debug.Log("Gengar weighs " + weight + "kg.");
        Debug.Log("Gengar's weaknesses are " + weaknesses[0] + ", "+ weaknesses[1] + ", "+ weaknesses[2] + " et "+ weaknesses[3]);
        Debug.Log("Gengar's resistances are " + resistance[0] + ", " + resistance[1] + ", " + resistance[2] + " et " + resistance[3]);
        Debug.Log("The statistic of Gengar is " + StatsPoints);

    }

    void Update()
    {
            if (current_life <= 0)
            {
                Debug.Log("Gengar's dead");
            }
            else if (current_life > 0)
            {
                Debug.Log("Gengar's alive");
            }
    }
}
