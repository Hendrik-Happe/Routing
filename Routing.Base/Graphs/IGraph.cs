namespace Routing.Base.Graphs
{
    public interface IGraph<TVertex, TEdge>
        where TVertex : IVertex
        where TEdge : IEdge<TVertex>
    {
        public IEnumerable<TEdge> GetOutgoingNeighbors(TVertex vertex);

        public IEnumerable<TEdge> GetIncomingNeighbors(TVertex vertex);

        public IEnumerable<TEdge> GetAllNeighbors(TVertex vertex);
    }
}
