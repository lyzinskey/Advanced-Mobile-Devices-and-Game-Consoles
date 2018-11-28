using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class PlayerManagement {
    private static readonly string FIGHTER = "Warrior";
    private static readonly string ASSASSIN = "Assassin";
    private static readonly string SAGE = "Sage";
    private static string character = FIGHTER;
    private static int level = 0;
    private static List<CardAsset> cards = new List<CardAsset>();
    public static int getLevel()
    {
        return level;

    }
    public static void setLevel(int x) {
        level = x;
    }
    public static void increaseLevel()
    {
        level++;
        Debug.Log("level is " + level);
    }
    public static void resetLevel() {
        level = 0;
    }
    public static void iniDeck() {
        Debug.Log(character);
        var Card_bludgeon = Resources.Load<CardAsset>("Spells/Bludgeon") as CardAsset;
        var Card_die_die_die = Resources.Load<CardAsset>("Spells/Die Die Die") as CardAsset;
        var Card_fireball = Resources.Load<CardAsset>("Spells/Fireball") as CardAsset;
        var Card_pommel_strike = Resources.Load<CardAsset>("Spells/Pommel Strike") as CardAsset;
        var Card_power = Resources.Load<CardAsset>("Spells/Power") as CardAsset;
        var Card_slice = Resources.Load<CardAsset>("Spells/Slice") as CardAsset;
        var Card_strike = Resources.Load<CardAsset>("Spells/Strike") as CardAsset;

        var Card_beast = Resources.Load<CardAsset>("Creatures/Beast") as CardAsset;
        var Card_burner = Resources.Load<CardAsset>("Creatures/Burner") as CardAsset;
        var Card_centurion = Resources.Load<CardAsset>("Creatures/Centurion") as CardAsset;
        var Card_conqueror = Resources.Load<CardAsset>("Creatures/Conqueror") as CardAsset;
        var Card_hammer = Resources.Load<CardAsset>("Creatures/Hammer") as CardAsset;
        var Card_iron_chain = Resources.Load<CardAsset>("Creatures/iron chain") as CardAsset;
        var Card_link = Resources.Load<CardAsset>("Creatures/Link") as CardAsset;
        var Card_ninja = Resources.Load<CardAsset>("Creatures/Ninja") as CardAsset;

        if (character == FIGHTER) {
            cards.Add(Card_iron_chain);
            cards.Add(Card_slice);
            cards.Add(Card_iron_chain);
            cards.Add(Card_strike);
            cards.Add(Card_power);
            cards.Add(Card_bludgeon);
            cards.Add(Card_power);
            cards.Add(Card_pommel_strike);
            cards.Add(Card_power);
            cards.Add(Card_iron_chain);
            cards.Add(Card_iron_chain);
            cards.Add(Card_hammer);
            cards.Add(Card_centurion);
            cards.Add(Card_beast);
            cards.Add(Card_power);
            cards.Add(Card_strike);
            cards.Add(Card_conqueror);
            cards.Add(Card_iron_chain);
            cards.Add(Card_hammer);
            cards.Add(Card_beast);
        } else if (character == ASSASSIN) {
            cards.Add(Card_power);
            cards.Add(Card_power);
            cards.Add(Card_power);
            cards.Add(Card_power);
            cards.Add(Card_power);
            cards.Add(Card_slice);
            cards.Add(Card_link);
            cards.Add(Card_ninja);
            cards.Add(Card_die_die_die);
            cards.Add(Card_slice);
            cards.Add(Card_link);
            cards.Add(Card_ninja);
            cards.Add(Card_die_die_die);
            cards.Add(Card_slice);
            cards.Add(Card_iron_chain);
            cards.Add(Card_iron_chain);
            cards.Add(Card_hammer);
            cards.Add(Card_beast);
            cards.Add(Card_beast);
            cards.Add(Card_centurion);
        } else if (character == SAGE) {
            cards.Add(Card_power);
            cards.Add(Card_power);
            cards.Add(Card_power);
            cards.Add(Card_power);
            cards.Add(Card_power);
            cards.Add(Card_power);

            cards.Add(Card_bludgeon);
            cards.Add(Card_fireball);
            cards.Add(Card_fireball);
            cards.Add(Card_slice);
            cards.Add(Card_beast);
            cards.Add(Card_burner);
            cards.Add(Card_centurion);
            cards.Add(Card_conqueror);
            cards.Add(Card_hammer);
            cards.Add(Card_iron_chain);
            cards.Add(Card_link);
            cards.Add(Card_ninja);
            cards.Add(Card_fireball);
            cards.Add(Card_link);
        }

    }
    public static List<CardAsset> getCard() {
        return cards;
    }
    public static void ChooseFighter() {
        character = FIGHTER;
    }
    public static void ChooseASSASSIN()
    {
        character = ASSASSIN;
    }

    public static void ChooseSAGE()
    {
        character = SAGE;
    }
}
