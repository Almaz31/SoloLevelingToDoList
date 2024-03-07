[System.Serializable]
public class PlayerStats 
{
    public int strength;
    public int dexterity;
    public int intelligence;
    public int wisdom;
    public int constitution;
    public int charisma;
    public PlayerStats(int _strength, int _dexterity, int _intelligence, int _wisdom, int _constitution, int _charisma) 
    {
        strength = _strength;
        dexterity = _dexterity;
        intelligence = _intelligence;
        wisdom = _wisdom;
        constitution = _constitution;
        charisma = _charisma;
    }
}
