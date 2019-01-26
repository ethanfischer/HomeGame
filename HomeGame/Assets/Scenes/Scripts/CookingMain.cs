﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum IngredientType
{
    CHICKEN_WINGS,
    ONIONS,
    JELLY,
    JALEPENOS,
    GRAPEFRUIT,
    SWEETTARTS,
    PICKLES,
    CRICKETS,
    MUSHROOM,
    BROTH,
    SODA,
    BELL_PEPPER,
    COFFEE,
    WINE,
    CLOVES,
    CORRIANDER,
}

public class CookingMain : MonoBehaviour
{
	public Ingredient[] AllIngredients { get { return m_ingredients; } }
	private Ingredient[] m_ingredients =
	{ 
		//												sa sw so sp b  u  m
		new Ingredient(IngredientType.CHICKEN_WINGS,    3, 0, 0, 0, 0, 8, 0),
		new Ingredient(IngredientType.ONIONS,           0, 0, 0, 0, 0, 0, 2),
		new Ingredient(IngredientType.JELLY,            0, 8, 1, 0, 0, 0, 0),
		new Ingredient(IngredientType.JALEPENOS,        0, 0, 0, 9, 0, 0, 0),
		new Ingredient(IngredientType.GRAPEFRUIT,       0, 2, 7, 0, 1, 8, 0),
		new Ingredient(IngredientType.SWEETTARTS,       0, 5, 5, 0, 0, 0, 0),
		new Ingredient(IngredientType.PICKLES,          4, 0, 6, 0, 0, 0, 0),
		new Ingredient(IngredientType.CRICKETS,         2, 1, 0, 0, 1, 6, 0),
		new Ingredient(IngredientType.MUSHROOM,         0, 0, 0, 0, 0, 5, 0),
		new Ingredient(IngredientType.BROTH,            4, 0, 0, 0, 0, 4, 1),
		new Ingredient(IngredientType.SODA,             0, 8, 0, 0, 2, 0, 0),
		new Ingredient(IngredientType.BELL_PEPPER,      0, 1, 1, 0, 0, 0, 0),
		new Ingredient(IngredientType.COFFEE,           0, 0, 0, 0, 9, 8, 0),
		new Ingredient(IngredientType.WINE,             0, 2, 3, 0, 0, 0, 1),
		new Ingredient(IngredientType.CLOVES,           0, 1, 0, 3, 0, 0, 0),
		new Ingredient(IngredientType.CORRIANDER,       0, 0, 0, 1, 0, 1, 1)
	};


}

public struct Ingredient
{
    private IngredientType m_type;
    public IngredientType Type { get { return m_type; } }

    private int m_salt;
    public int Salt { get { return m_salt; } }
    private int m_sweet;
    public int Sweet { get { return m_sweet; } }
    private int m_sour;
    public int Sour { get { return m_sour; } }
    private int m_spicy;
    public int Spicy { get { return m_spicy; } }
    private int m_bitter;
    public int Bitter { get { return m_bitter; } }
    private int m_umami;
    public int Umami { get { return m_umami; } }
    private int m_multiplier;
    public int Multiplier { get { return m_multiplier; } }


    public Ingredient(IngredientType type, int salt, int sweet, int sour, int spicy, int bitter, int umami, int multiplier)
    {
        m_type = type;
        m_salt = salt;
        m_sweet = sweet;
        m_sour = sour;
        m_spicy = spicy;
        m_bitter = bitter;
        m_umami = umami;
        m_multiplier = multiplier;
    }
}

public class Stew
{
	public List<Ingredient> m_ingredients = new List<Ingredient>();

	public int FinalScore()
	{
		int simpleScore = BaseScore();
		int multiplier = Multiplier();

		return simpleScore * multiplier;
	}

	public int BaseScore() { return GetScore((i) => { return i.Salt + i.Sweet + i.Sour + i.Spicy + i.Bitter + i.Umami; }); }
	public int Multiplier() { return GetScore((i) => { return i.Multiplier; }) + 1; }
	public int Saltiness() { return GetScore((i) => { return i.Salt; }); }
	public int Sweetness() { return GetScore((i) => { return i.Sweet; }); }
	public int Sourness() { return GetScore((i) => { return i.Sour; }); }
	public int Spiciness() { return GetScore((i) => { return i.Spicy; }); }
	public int Bitterness() { return GetScore((i) => { return i.Bitter; }); }
	public int Umiminess() { return GetScore((i) => { return i.Umami; }); }


	delegate int ScoreDelegate(Ingredient ingredient);
	private int GetScore(ScoreDelegate scoreCalculator)
	{
		int score = 0;
		for (int i = 0; i < m_ingredients.Count; i++)
		{
			score += scoreCalculator(m_ingredients[i]);
		}
		return score;
	}
}