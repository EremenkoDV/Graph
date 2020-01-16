using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            Vertex v1 = new Vertex(1);
            Vertex v2 = new Vertex(2);
            Vertex v3 = new Vertex(3);
            Vertex v4 = new Vertex(4);
            Vertex v5 = new Vertex(5);
            Vertex v6 = new Vertex(6);
            Vertex v7 = new Vertex(7);

            graph.AddVertex(v1);
            graph.AddVertex(v2);
            graph.AddVertex(v3);
            graph.AddVertex(v4);
            graph.AddVertex(v5);
            graph.AddVertex(v6);
            graph.AddVertex(v7);

            graph.AddEdge(v1, v2);
            graph.AddEdge(v1, v3);
            graph.AddEdge(v3, v4);
            graph.AddEdge(v2, v5);
            graph.AddEdge(v2, v6);
            graph.AddEdge(v6, v5);
            graph.AddEdge(v5, v6);

            GetVertexMatrix(graph);

            Console.WriteLine("\n\n");

            GetVertexList(graph, v1);
            GetVertexList(graph, v2);
            GetVertexList(graph, v3);
            GetVertexList(graph, v4);
            GetVertexList(graph, v5);
            GetVertexList(graph, v6);
            GetVertexList(graph, v7);

            Console.ReadKey();
        }

        private static void GetVertexMatrix(Graph graph)
        {
            var matrix = graph.GetMatrix();
            Console.Write("|   |");
            for (int j = 0; j < graph.VertexesCount; j++)
            {
                Console.Write(String.Format("{0,3}", j + 1) + "|");
            }
            Console.WriteLine();
            PrintLine(graph.VertexesCount + 1);
            for (int i = 0; i < graph.VertexesCount; i++)
            {
                Console.Write("|" + String.Format("{0,3}", i + 1) + "|");
                for (int j = 0; j < graph.VertexesCount; j++)
                {
                    Console.Write(String.Format("{0,3}", matrix[i, j]) + "|");
                }
                Console.WriteLine();
                PrintLine(graph.VertexesCount + 1);
            }
        }

        private static void GetVertexList(Graph graph, Vertex vertexFrom)
        {
            int i = 0;
            Console.Write("Vertex List for Vertex(" + vertexFrom.ToString() + ") is :(");
            foreach (Vertex vertex in graph.GetVertexList(vertexFrom))
            {
                if (i++ > 0) Console.Write(", ");
                Console.Write(vertex);
            }
            Console.WriteLine(")");
        }

        private static void PrintLine(int count)
        {
            Console.Write("+");
            for (int j = 0; j < count; j++)
            {
                Console.Write("---+");
            }
            Console.WriteLine();
        }

    }
}
