using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CommonCard : MonoBehaviour
{
    [SerializeField] private List<SpriteRenderer> _cards;

    public bool CheatDeck;
    private int _currentIndex = 0;
    public List<Sprite> CommonDeck;
    public List<Sprite> HighDeck;
    public List<Sprite> TomeDeck;
    public List<Sprite> RavenkindDeck;
    public List<Sprite> SwordDeck;
    public List<Sprite> EnemyDeck;
    public List<Sprite> LocationDeck;
    public List<Sprite> MuriilDeck;
    public List<Sprite> DaonlimDeck;
    public List<Sprite> KraahraarkDeck;
    public List<Sprite> AoeliousDeck;

    public List<Sprite> CardsToRemove;

    public List<Sprite> SetDeck;

    private void Awake()
    {
        foreach (SpriteRenderer spriteRenderer in _cards)
        {
            spriteRenderer.DOFade(0, 0);
        }

        foreach (Sprite card in CardsToRemove)
        {
            TomeDeck.Remove(card);
            RavenkindDeck.Remove(card);
            SwordDeck.Remove(card);
            EnemyDeck.Remove(card);
            LocationDeck.Remove(card);
        }
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (CheatDeck)
            {
                DrawSet();
            }
            else
            {
                DrawRandom();
            }
        }
    }

    private void DrawRandom()
    {
        switch (_currentIndex)
        {
            case 0:
                DrawTome();
                break;
            case 1:
                DrawRavenkind();
                break;
            case 2:
                DrawSword();
                break;
            case 3:
                DrawEnemy();
                break;
            case 4:
                DrawLocation();
                break;
        }
    }

    public void DrawSet()
    {
        Sprite card;

            card = SetDeck[_currentIndex];


        _cards[_currentIndex].sprite = card;
        _cards[_currentIndex].DOFade(1, 1);
        _currentIndex++;
    }

    public void DrawTome()
    {
        Sprite card = TomeDeck.GetRandom();
        TomeDeck.Remove(card);
        RavenkindDeck.Remove(card);
        SwordDeck.Remove(card);
        _cards[_currentIndex].sprite = card;
        _cards[_currentIndex].DOFade(1, 1);
        _currentIndex++;
    }

    public void DrawRavenkind()
    {
        Sprite card = RavenkindDeck.GetRandom();
        TomeDeck.Remove(card);
        RavenkindDeck.Remove(card);
        SwordDeck.Remove(card);
        _cards[_currentIndex].sprite = card;
        _cards[_currentIndex].DOFade(1, 1);
        _currentIndex++;
    }

    public void DrawSword()
    {
        Sprite card = SwordDeck.GetRandom();
        TomeDeck.Remove(card);
        RavenkindDeck.Remove(card);
        SwordDeck.Remove(card);
        _cards[_currentIndex].sprite = card;
        _cards[_currentIndex].DOFade(1, 1);
        _currentIndex++;
    }

    public void DrawEnemy()
    {
        Sprite card = EnemyDeck.GetRandom();
        EnemyDeck.Remove(card);
        LocationDeck.Remove(card);
        _cards[_currentIndex].sprite = card;
        _cards[_currentIndex].DOFade(1, 1);
        _currentIndex++;
    }

    public void DrawLocation()
    {
        Sprite card = LocationDeck.GetRandom();
        EnemyDeck.Remove(card);
        LocationDeck.Remove(card);
        _cards[_currentIndex].sprite = card;
        _cards[_currentIndex].DOFade(1, 1);
        _currentIndex++;
    }

    public void DrawHigh()
    {
        Sprite card = HighDeck.GetRandom();
        HighDeck.Remove(card);
        _cards[_currentIndex].sprite = card;
        _cards[_currentIndex].DOFade(1, 1);
        _currentIndex++;
    }

    public void DrawCommon()
    {
        Sprite card = CommonDeck.GetRandom();
        CommonDeck.Remove(card);
        _cards[_currentIndex].sprite = card;
        _cards[_currentIndex].DOFade(1, 1);
        _currentIndex++;
    }
}