using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Graph
    {
        public List<Vertex> Vertexes = new List<Vertex>();

        public List<Edge> Edges = new List<Edge>();

        public int VertexesCount => Vertexes.Count;

        public int EdgesCount => Edges.Count;

        public void AddVertex(Vertex vertex)
        {
            Vertexes.Add(vertex);
        }

        public void AddEdge(Vertex from, Vertex to)
        {
            Edges.Add(new Edge(from, to));
        }

        public int[,] GetMatrix()
        {
            var matrix = new int[Vertexes.Count, Vertexes.Count];

            foreach (var edge in Edges)
            {
                var row = edge.From.Number - 1;
                var column = edge.To.Number - 1;
                matrix[row, column] = edge.Weight;
            }

            return matrix;
        }

        public List<Vertex> GetVertexList(Vertex vertex)
        {
            List<Vertex> result = new List<Vertex>();
            foreach (Edge edge in Edges)
            {
                if (edge.From == vertex)
                {
                    result.Add(edge.To);
                }
            }
            return result;
        }

        public List<Vertex> GetWaveVertexList(Vertex start, Vertex finish)
        {
            List<Vertex> result = new List<Vertex>();

            List<Vertex> list = new List<Vertex>();

            Vertex currentVertex = start;

            while ()
            {

                foreach (Vertex vertex in GetVertexList(currentVertex))
                {
                    if (vertex == finish)
                    {
                        list.Add(vertex);
                        break;
                    }
                }
                currentVertex = vertex;
            }

            return result;
        }

    }
}
