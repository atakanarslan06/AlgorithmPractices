using System;
using System.Collections.Generic;

class Graph
{
    private int vertexCount; // Grafikteki düğüm sayısı

    private List<int>[] adjacencyList; // Düğümlerin bağlantılarını tutan liste

    public Graph(int vertices)
    {
        vertexCount = vertices;
        adjacencyList = new List<int>[vertices];

        for (int i = 0; i < vertices; ++i)
        {
            adjacencyList[i] = new List<int>(); // Her düğüm için boş bir bağlantı listesi oluşturulur
        }
    }

    // Grafikte kenar eklemek için yardımcı bir metod
    public void AddEdge(int v, int w)
    {
        adjacencyList[v].Add(w); // Düğüme kenar ekleme
    }

    // DFS algoritması
    public void DepthFirstSearch(int startVertex)
    {
        bool[] visited = new bool[vertexCount]; // Ziyaret edilen düğümleri takip etmek için bir dizi oluşturulur

        DFS(startVertex, visited); // Yardımcı DFS metodu çağrılır
    }

    // DFS'nin yardımcı metodu
    private void DFS(int vertex, bool[] visited)
    {
        visited[vertex] = true; // Mevcut düğüm ziyaret edildi olarak işaretlenir
        Console.Write(vertex + " "); // Düğüm yazdırılır

        // Ziyaret edilmemiş tüm komşu düğümleri gez
        foreach (int adjacentVertex in adjacencyList[vertex])
        {
            if (!visited[adjacentVertex])
            {
                DFS(adjacentVertex, visited); // Komşu düğümü ziyaret etmek için DFS çağrılır
            }
        }
    }
}

class DFSTest
{
    static void Main()
    {
        Graph graph = new Graph(4); // Bir grafik oluşturulur

        // Grafik için kenarlar eklenir
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 2);
        graph.AddEdge(2, 0);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 3);

        Console.WriteLine("DFS Traversal: ");

        graph.DepthFirstSearch(2); // DFS çağrılır ve başlangıç düğümü verilir
    }
}
