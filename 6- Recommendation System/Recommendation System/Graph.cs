using System;

namespace Recommendation_System
{
    class Graph
    {
        public class Edge : IComparable<Edge>
        {
            public int src, dest, weight;
            // Sort Edges By Comparing Weights
            public int CompareTo(Edge compareEdge)
            {
                return this.weight - compareEdge.weight;
            }
        }

        public class subset
        {
            public int parent, rank;
        };
        public int resultantDestination = 0, resultantWeight = 0;
        int V, E, shortestEdge = 0;
        public Edge[] edge;
        Edge[] result;

        public Graph(int v, int e)
        {
            V = v;
            E = e;
            edge = new Edge[E];
            for (int i = 0; i < e; ++i)
                edge[i] = new Edge();
        }

        int find(subset[] subsets, int i)
        {
            if (subsets[i].parent != i)
                subsets[i].parent = find(subsets, subsets[i].parent);
            return subsets[i].parent;
        }

        void Union(subset[] subsets, int x, int y)
        {
            int xroot = find(subsets, x);
            int yroot = find(subsets, y);
            if (subsets[xroot].rank < subsets[yroot].rank)
                subsets[xroot].parent = yroot;
            else if (subsets[xroot].rank > subsets[yroot].rank)
                subsets[yroot].parent = xroot;
            else
            {
                subsets[yroot].parent = xroot;
                subsets[xroot].rank++;
            }
        }

        public void KruskalMST()
        {
            result = new Edge[V];
            int e = 0;
            int i = 0;
            for (i = 0; i < V; ++i)
                result[i] = new Edge();
            Array.Sort(edge);

            subset[] subsets = new subset[V];
            for (i = 0; i < V; ++i)
                subsets[i] = new subset();

            for (int v = 0; v < V; ++v)
            {
                subsets[v].parent = v;
                subsets[v].rank = 0;
            }

            i = 0;
            while (e < V - 1)
            {
                Edge next_edge = new Edge();
                next_edge = edge[i++];
                int x = find(subsets, next_edge.src);
                int y = find(subsets, next_edge.dest);
                if (x != y)
                {
                    result[e++] = next_edge;
                    Union(subsets, x, y);
                }
            }
            shortestEdge = e;
        }
        public void displayShortestPath(int inputSrc)
        {
            int minimumCost = 0;
            for (int i = 0; i < shortestEdge; ++i)
            {
                if (result[i].src == inputSrc)
                {
                    Console.WriteLine(result[i].src + " -- " + result[i].dest + " == " + result[i].weight);
                    resultantDestination = result[i].dest;
                    resultantWeight = result[i].weight;
                    return;
                }
                minimumCost += result[i].weight;
            }
        }

    }
}
