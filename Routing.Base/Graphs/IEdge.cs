namespace Routing.Base.Graphs
{
    public interface IEdge<TVertex>
        where TVertex : IVertex
    {
        public int Weight { get; }

        public TVertex Source { get; }

        public TVertex Target { get; }
    }
}
