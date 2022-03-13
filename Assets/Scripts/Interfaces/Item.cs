public interface Item
{
    public bool CanEquip(int rank, MainChar adventurer);
    public bool DoTypesMatch(MainChar survivor);
}
