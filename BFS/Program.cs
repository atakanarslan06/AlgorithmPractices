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

    // BFS algoritması
    public void BreadthFirstSearch(int startVertex)
    {
        bool[] visited = new bool[vertexCount]; // Ziyaret edilen düğümleri takip etmek için bir dizi oluşturulur

        Queue<int> queue = new Queue<int>(); // BFS için kuyruk oluşturulur

        visited[startVertex] = true; // Başlangıç düğümü ziyaret edildi olarak işaretlenir
        queue.Enqueue(startVertex); // Kuyruğa başlangıç düğümü eklenir

        while (queue.Count != 0)
        {
            startVertex = queue.Dequeue(); // Kuyruktan bir düğüm çıkarılır ve ziyaret edilir
            Console.Write(startVertex + " "); // Düğüm yazdırılır

            // Ziyaret edilmemiş tüm komşu düğümleri bul ve işaretle
            foreach (int adjacentVertex in adjacencyList[startVertex])
            {
                if (!visited[adjacentVertex])
                {
                    visited[adjacentVertex] = true; // Komşu düğüm ziyaret edildi olarak işaretlenir
                    queue.Enqueue(adjacentVertex); // Kuyruğa eklenir
                }
            }
        }
    }
}

class BFSTest
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

        Console.WriteLine("BFS Traversal: ");

        graph.BreadthFirstSearch(2); // BFS çağrılır ve başlangıç düğümü verilir
    }
}
