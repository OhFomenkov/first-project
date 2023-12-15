using System;
using System.Collections.Generic;

class Graph
{
    private int numVertices;
    private int[,] adjMatrix;

    public Graph(int numVertices)
    {
        this.numVertices = numVertices;
        adjMatrix = new int[numVertices, numVertices];
    }

    public void AddEdge(int v1, int v2)
    {
        if (v1 >= numVertices || v2 >= numVertices)
        {
            throw new IndexOutOfRangeException("Vertex index out of range");
        }
        adjMatrix[v1, v2] = 1;
        adjMatrix[v2, v1] = 1;
    }

    public void PrintAdjacencyMatrix()
    {
        Console.WriteLine("Матрица смежности:");
        for (int i = 0; i < numVertices; i++)
        {
            for (int j = 0; j < numVertices; j++)
            {
                Console.Write(adjMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void PrintIncidenceMatrix()
    {
        int numEdges = CountEdges();
        int[,] incidenceMatrix = new int[numVertices, numEdges];
        int currentEdge = 0;

        Console.WriteLine("Матрица инцидентности:");

        for (int i = 0; i < numVertices; i++)
        {
            for (int j = i + 1; j < numVertices; j++)
            {
                if (adjMatrix[i, j] == 1)
                {
                    incidenceMatrix[i, currentEdge] = 1;
                    incidenceMatrix[j, currentEdge] = 1;
                    currentEdge++;
                }
            }
        }

        for (int i = 0; i < numVertices; i++)
        {
            for (int j = 0; j < numEdges; j++)
            {
                Console.Write(incidenceMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void PrintIncidentEdgesList()
    {
        int numEdges = CountEdges();
        List<Tuple<int, int>> edgesList = new List<Tuple<int, int>>();

        Console.WriteLine("Список инцидентных ребер:");

        for (int i = 0; i < numVertices; i++)
        {
            for (int j = i + 1; j < numVertices; j++)
            {
                if (adjMatrix[i, j] == 1)
                {
                    edgesList.Add(new Tuple<int, int>(i, j));
                }
            }
        }

        foreach (var edge in edgesList)
        {
            Console.WriteLine(edge.Item1 + " - " + edge.Item2);
        }
        Console.WriteLine();
    }

    public void PrintAdjacentVerticesList()
    {
        Console.WriteLine("Список смежных вершин:");

        for (int i = 0; i < numVertices; i++)
        {
            Console.Write(i + ": ");
            for (int j = 0; j < numVertices; j++)
            {
                if (adjMatrix[i, j] == 1)
                {
                    Console.Write(j + " ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void DFS(int startVertex)
    {
        bool[] visited = new bool[numVertices];
        DFSUtil(startVertex, visited);
        Console.WriteLine();
    }

    private void DFSUtil(int vertex, bool[] visited)
    {
        visited[vertex] = true;
        Console.Write(vertex + " ");

        for (int i = 0; i < numVertices; i++)
        {
            if (adjMatrix[vertex, i] == 1 && !visited[i])
            {
                DFSUtil(i, visited);
            }
        }
    }

    public void BFS(int startVertex)
    {
        bool[] visited = new bool[numVertices];
        Queue<int> queue = new Queue<int>();

        visited[startVertex] = true;
        queue.Enqueue(startVertex);

        while (queue.Count > 0)
        {
            int vertex = queue.Dequeue();
            Console.Write(vertex + " ");

            for (int i = 0; i < numVertices; i++)
            {
                if (adjMatrix[vertex, i] == 1 && !visited[i])
                {
                    visited[i] = true;
                    queue.Enqueue(i);
                }
            }
        }
        Console.WriteLine();
    }

    private int CountEdges()
    {
        int count = 0;

        for (int i = 0; i < numVertices; i++)
        {
            for (int j = i + 1; j < numVertices; j++)
            {
                if (adjMatrix[i, j] == 1)
                {
                    count++;
                }
            }
        }

        return count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание графа
        Graph graph = new Graph(8);
        graph.AddEdge(0, 4);
        graph.AddEdge(0, 5);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(1, 4);
        graph.AddEdge(2, 4);
        graph.AddEdge(2, 7);
        graph.AddEdge(6, 4);
        graph.AddEdge(6, 7);
        graph.AddEdge(3, 4);
        graph.AddEdge(4, 5);
        graph.AddEdge(7, 4);

        // Вывод матрицы инцидентности
        graph.PrintIncidenceMatrix();

        // Вывод списка смежных вершин
        graph.PrintAdjacentVerticesList();

        // Вывод матрицы смежности
        graph.PrintAdjacencyMatrix();

        // Вывод списка инцидентных ребер
        graph.PrintIncidentEdgesList();



        // Обход графа в глубину (DFS)
        Console.WriteLine("Обход графа в глубину (DFS):");
        graph.DFS(5);

        // Обход графа в ширину (BFS)
        Console.WriteLine("Обход графа в ширину (BFS):");
        graph.BFS(2);
    }
}

