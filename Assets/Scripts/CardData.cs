using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Deck
{
    Common,
    High
}

public enum Suit
{
    Swords,
    Stars,
    Coins,
    Glyphs,
    High
}

public enum Rank
{
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Master,
    High
}

public enum Name
{
    Artifact,
    Beast,
    Broken_One,
    Darklord,
    Donjon,
    Ghost,
    Executioner,
    Horseman,
    Innocent,
    Marionette,
    Mists,
    Raven,
    Seer,
    Tempter,
    Warrior,
    Avenger,
    Paladin,
    Soldier,
    Mercenary,
    Myrmidon,
    Berserker,
    Hooded_One,
    Dictator,
    Torturer,
    Wizard,
    Transmuter,
    Diviner,
    Enchanter,
    Abjurer,
    Elementalist,
    Evoker,
    Illusionist,
    Necromancer,
    Conjurer,
    Rogue,
    Swashbuckler,
    Philanthropist,
    Trader,
    Merchant,
    Guild_Member,
    Beggar,
    Thief,
    Tax_Collector,
    Miser,
    Priest,
    Monk,
    Missionary,
    Healer,
    Shepherd,
    Druid,
    Anarchist,
    Charlatan,
    Bishop,
    Traitor

}
[CreateAssetMenu(fileName = "Card", menuName = "ScriptableObjects/TarokkaCard", order = 1)]
public class CardData : ScriptableObject
{
    public Sprite Card;
    public Deck Deck;
    public Rank Rank;
    public Suit Suit;
    public Name Name;
    public string Represents;
    
}
