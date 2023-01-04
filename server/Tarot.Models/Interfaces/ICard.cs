namespace Tarot.Models;

public interface ICard
{
    public int Id { get; }
    public string Name { get; }
    public string Type { get; }
    public string Image { get; }
}