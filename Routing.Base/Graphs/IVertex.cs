namespace Routing.Base.Graphs
{
    public interface IVertex : IEquatable<IVertex>
    {
        public int Index { get; }
    }
}
