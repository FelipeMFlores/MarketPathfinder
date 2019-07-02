using System;	
using System.Collections.Generic;

public class GraphMap
{
  static public int[,] graphMap;
  static public List<int[]> permut;
  static public int[,] distance; /* = {
      { 0, 1, 4, 6, 7, 10, 8, 7, 6, 5, 4, 2, 4, 6, 7, 8, 9, 10, 13, 12, 11, 11, 10, 7, 5, } ,
{ 1, 0, 3, 5, 6, 9, 7, 6, 5, 6, 5, 3, 5, 7, 8, 7, 8, 9, 12, 11, 10, 11, 11, 8, 6, } ,
{ 4, 3, 0, 3, 4, 7, 4, 3, 2, 3, 4, 6, 6, 6, 5, 4, 5, 6, 9, 8, 7, 8, 9, 9, 7, } ,
{ 6, 5, 3, 0, 1, 4, 7, 6, 5, 6, 7, 8, 9, 9, 8, 7, 8, 9, 11, 11, 10, 11, 12, 12, 10, } ,
{ 7, 6, 4, 1, 0, 3, 6, 7, 6, 7, 8, 9, 10, 10, 9, 8, 9, 10, 10, 12, 11, 12, 13, 13, 11, } ,
{ 10, 9, 7, 4, 3, 0, 3, 4, 7, 9, 10, 12, 12, 11, 10, 9, 10, 9, 7, 10, 11, 13, 14, 15, 13, } ,
{ 8, 7, 4, 7, 6, 3, 0, 1, 4, 6, 7, 9, 9, 8, 7, 6, 7, 6, 9, 10, 9, 10, 11, 12, 10, } ,
{ 7, 6, 3, 6, 7, 4, 1, 0, 3, 5, 6, 8, 8, 7, 6, 5, 6, 7, 10, 9, 8, 9, 10, 11, 9, } ,
{ 6, 5, 2, 5, 6, 7, 4, 3, 0, 3, 4, 6, 6, 4, 3, 2, 3, 4, 7, 6, 5, 6, 7, 9, 7, } ,
{ 5, 6, 3, 6, 7, 9, 6, 5, 3, 0, 1, 3, 3, 5, 6, 5, 6, 7, 10, 9, 8, 9, 9, 6, 4, } ,
{ 4, 5, 4, 7, 8, 10, 7, 6, 4, 1, 0, 2, 2, 4, 5, 6, 7, 8, 11, 10, 9, 9, 8, 5, 3, } ,
{ 2, 3, 6, 8, 9, 12, 9, 8, 6, 3, 2, 0, 2, 4, 5, 8, 9, 10, 13, 12, 11, 9, 8, 5, 3, } ,
{ 4, 5, 6, 9, 10, 12, 9, 8, 6, 3, 2, 2, 0, 2, 3, 6, 8, 9, 12, 10, 9, 7, 6, 3, 1, } ,
{ 6, 7, 6, 9, 10, 11, 8, 7, 4, 5, 4, 4, 2, 0, 1, 4, 6, 7, 10, 8, 7, 8, 8, 5, 3, } ,
{ 7, 8, 5, 8, 9, 10, 7, 6, 3, 6, 5, 5, 3, 1, 0, 3, 5, 6, 9, 7, 6, 7, 8, 6, 4, } ,
{ 8, 7, 4, 7, 8, 9, 6, 5, 2, 5, 6, 8, 6, 4, 3, 0, 3, 4, 7, 4, 3, 4, 5, 8, 7, } ,
{ 9, 8, 5, 8, 9, 10, 7, 6, 3, 6, 7, 9, 8, 6, 5, 3, 0, 1, 4, 7, 6, 7, 8, 11, 9, } ,
{ 10, 9, 6, 9, 10, 9, 6, 7, 4, 7, 8, 10, 9, 7, 6, 4, 1, 0, 3, 6, 7, 8, 9, 12, 10, } ,
{ 13, 12, 9, 11, 10, 7, 9, 10, 7, 10, 11, 13, 12, 10, 9, 7, 4, 3, 0, 3, 4, 9, 10, 13, 13, } ,
{ 12, 11, 8, 11, 12, 10, 10, 9, 6, 9, 10, 12, 10, 8, 7, 4, 7, 6, 3, 0, 1, 6, 7, 10, 11, } ,
{ 11, 10, 7, 10, 11, 11, 9, 8, 5, 8, 9, 11, 9, 7, 6, 3, 6, 7, 4, 1, 0, 5, 6, 9, 10, } ,
{ 11, 11, 8, 11, 12, 13, 10, 9, 6, 9, 9, 9, 7, 8, 7, 4, 7, 8, 9, 6, 5, 0, 1, 4, 7, } ,
{ 10, 11, 9, 12, 13, 14, 11, 10, 7, 9, 8, 8, 6, 8, 8, 5, 8, 9, 10, 7, 6, 1, 0, 3, 6, } ,
{ 7, 8, 9, 12, 13, 15, 12, 11, 9, 6, 5, 5, 3, 5, 6, 8, 11, 12, 13, 10, 9, 4, 3, 0, 3, } ,
{ 5, 6, 7, 10, 11, 13, 10, 9, 7, 4, 3, 3, 1, 3, 4, 7, 9, 10, 13, 11, 10, 7, 6, 3, 0, }
  };*/
}

public class Graph<T> {
    public Graph() {}
    public Graph(IEnumerable<T> vertices, IEnumerable<Tuple<T,T>> edges) {
        foreach(var vertex in vertices)
            AddVertex(vertex);

        foreach(var edge in edges)
            AddEdge(edge);
    }

    public Dictionary<T, HashSet<T>> AdjacencyList { get; } = new Dictionary<T, HashSet<T>>();

    public void AddVertex(T vertex) {
        AdjacencyList[vertex] = new HashSet<T>();
    }

    public void AddEdge(Tuple<T,T> edge) {
        if (AdjacencyList.ContainsKey(edge.Item1) && AdjacencyList.ContainsKey(edge.Item2)) {
            AdjacencyList[edge.Item1].Add(edge.Item2);
            AdjacencyList[edge.Item2].Add(edge.Item1);
        }
    }
}

public class Algorithms {
    public HashSet<T> DFS<T>(Graph<T> graph, T start) {
        var visited = new HashSet<T>();

        if (!graph.AdjacencyList.ContainsKey(start))
            return visited;
            
        var stack = new Stack<T>();
        stack.Push(start);

        while (stack.Count > 0) {
            var vertex = stack.Pop();

            if (visited.Contains(vertex))
                continue;

            visited.Add(vertex);

            foreach(var neighbor in graph.AdjacencyList[vertex])
                if (!visited.Contains(neighbor))
                    stack.Push(neighbor);
        }

        return visited;
    }
}
public class Graphs
{
     public const int cst = 9999;
    static void FloydWarshall(int[,] graph, int verticesCount)
    {
        GraphMap.distance = new int[verticesCount, verticesCount];

        for (int i = 0; i < verticesCount; ++i)
            for (int j = 0; j < verticesCount; ++j)
                GraphMap.distance[i, j] = graph[i, j];

        for (int k = 0; k < verticesCount; ++k)
        {
            for (int i = 0; i < verticesCount; ++i)
            {
                for (int j = 0; j < verticesCount; ++j)
                {
                    if (GraphMap.distance[i, k] + GraphMap.distance[k, j] < GraphMap.distance[i, j])
                        GraphMap.distance[i, j] = GraphMap.distance[i, k] + GraphMap.distance[k, j];
                }
            }
        }
    
    }


    static void StartGraph(){

        GraphMap.graphMap = new int[25,25];

        for (int i = 0; i < 25; i++){
            for (int j = i; j < 25; j++){
                Add(i,j,cst);
            }
        }
        for (int i = 0; i < 25; i++)
        {
            Add(i,i,0);
        }
      
        //Add(24, 11, 3);
        //Add(24, 12, 1);
        //Add(24, 23, 3);
        //Add(24, 0, 1);
         GraphMap.graphMap[24,0] = 1;
        //Add(24, 10, 1);
        // GraphMap.graphMap[24,10] = 1;
        //Add(24, 13, 1);
       //  GraphMap.graphMap[24,13] = 1;
        //Add(24, 22, 1);
         GraphMap.graphMap[24,22] = 1;
        //----------------
        Add(0, 1, 2);
        Add(0, 11, 5);
        //---------------
        Add(1, 2, 3);
        //--------------------
        Add(2, 3, 2);
        Add(2, 4, 5);
        Add(2, 6, 5);
        Add(2, 9, 7);
        Add(2, 11, 6);
        //------------
        Add(3, 4, 3);
        Add(3, 5, 5);
        //---------------
        Add(4, 5, 3);
        Add(4, 5, 4);   
        //------------------
        Add(5, 7, 2);
        //-------------------
        Add(6, 7, 2);
        Add(6, 11, 6);
        Add(6, 9, 6);
        //----------------
        Add(7, 8, 3);
        //-------------------
        Add(8, 9, 5);
        //--------------------
        Add(9, 10, 3);
        //---------------------
        Add(10, 11, 5);

        FloydWarshall(GraphMap.graphMap, 12);
    
    }

    static void Add(int i, int j, int peso){
        GraphMap.graphMap[i,j] = peso;
        GraphMap.graphMap[j,i] = peso;
    }

    static public List<int> BestRoute(List<int> products, int start){
        StartGraph();
        List<int> rt = new List<int>();
        if(start != 24){
            rt.Add(start);
            products.Remove(start);
        }
        int curent = start;
        int best = cst;
        int candidate;
        while(products.Count != 0){
            best = cst;
            var len = products.Count;
            candidate = products[0];
            for (int i = 0; i < len; i++)
            {
                if(GraphMap.distance[curent, products[i]] == 1){
                    candidate = products[i];
                    break;
                }
                if (best > GraphMap.distance[curent, products[i]]){
                    best = GraphMap.distance[curent, products[i]];
                    candidate = products[i];
                }
            }
            rt.Add(candidate);
            products.Remove(candidate);
            curent = candidate;

        }



        return rt;

    } 


    
}

