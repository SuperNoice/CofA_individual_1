using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace individual
{
    class Graph
    {
        private List<Vertex> vertexList;
        private List<Edge> edgeList;
        public string name { get; set; }
        private List<Edge> stackEdge;
        private List<Vertex> stackVertex;

        public Graph()
        {
            vertexList = new List<Vertex>();
            edgeList = new List<Edge>();
            stackEdge = new List<Edge>();
            stackVertex = new List<Vertex>();
            name = "";
        }

        public Graph(string newName)
        {
            vertexList = new List<Vertex>();
            edgeList = new List<Edge>();
            stackEdge = new List<Edge>();
            stackVertex = new List<Vertex>();
            name = newName;
        }

        public void setupGraph(int[,] matrSm)
        {
            int size = System.Convert.ToInt32(System.Math.Sqrt(matrSm.Length));
            for (int i = 0; i < size; i++)
                addVertex();

            string type = "";
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    if (matrSm[i, j] * matrSm[j, i] > 0) type = "both";
                    if (matrSm[i, j] > 0 && matrSm[j, i] <= 0) type = "to";
                    if (matrSm[i, j] <= 0 && matrSm[j, i] > 0) type = "from";

                    if (matrSm[i, j] != 0)
                        addEdge(vertexList[i], vertexList[j], matrSm[i, j], type);
                }
        }

        public List<Vertex> getVertexList()
        {
            return vertexList;
        }

        public List<Edge> getEdgeList()
        {
            return edgeList;
        }

        public void setName(string newName)
        {
            name = newName;
        }

        public Vertex addVertex()
        {
            Vertex newVertex = new Vertex(vertexList.Count());
            vertexList.Add(newVertex);
            return newVertex;
        }

        public Vertex addVertex(string newName)
        {
            Vertex newVertex = new Vertex(vertexList.Count(), newName);
            vertexList.Add(newVertex);
            return newVertex;
        }

        public Edge addEdge(Vertex transmitter, Vertex Receiver, int Weight, string Type)
        {
            Edge newEdge = new Edge(transmitter, Receiver, Weight, edgeList.Count(), Type);
            edgeList.Add(newEdge);

            if (Type == "both")
            {
                if (!Receiver.getAdjacentVertexList().Contains(transmitter))
                    Receiver.addAdjacentVertex(ref transmitter);
                if (!transmitter.getAdjacentVertexList().Contains(Receiver))
                    transmitter.addAdjacentVertex(ref Receiver);
            }
            if (Type == "to")
            {
                if (!transmitter.getAdjacentVertexList().Contains(Receiver))
                    transmitter.addAdjacentVertex(ref Receiver);
            }
            if (Type == "from")
            {
                if (!Receiver.getAdjacentVertexList().Contains(transmitter))
                    Receiver.addAdjacentVertex(ref transmitter);
            }
            return newEdge;
        }

        public Edge addEdge(string Type)
        {
            Vertex transmitter = new Vertex(vertexList.Count());
            vertexList.Add(transmitter);
            Vertex Receiver = new Vertex(vertexList.Count());
            vertexList.Add(Receiver);
            Edge newEdge = new Edge(transmitter, Receiver, edgeList.Count(), 0, Type);
            edgeList.Add(newEdge);

            if (Type == "both")
            {
                if (!Receiver.getAdjacentVertexList().Contains(transmitter))
                    Receiver.addAdjacentVertex(ref transmitter);
                if (!transmitter.getAdjacentVertexList().Contains(Receiver))
                    transmitter.addAdjacentVertex(ref Receiver);
            }
            if (Type == "to")
            {
                if (!transmitter.getAdjacentVertexList().Contains(Receiver))
                    transmitter.addAdjacentVertex(ref Receiver);
            }
            if (Type == "from")
            {
                if (!Receiver.getAdjacentVertexList().Contains(transmitter))
                    Receiver.addAdjacentVertex(ref transmitter);
            }
            return newEdge;
        }

        private bool checkForRecCountWays(Vertex now, Vertex next)
        {
            bool f = false;
            for (int i = 0; i < stackEdge.Count; i++)
                if ((stackEdge[i].GetTransmitter().GetHashCode() == now.GetHashCode() && stackEdge[i].GetReceiver().GetHashCode() == next.GetHashCode()) || (stackEdge[i].GetTransmitter().GetHashCode() == next.GetHashCode() && stackEdge[i].GetReceiver().GetHashCode() == now.GetHashCode()))
                    f = true;

            return f;
        }
        private int recCountWays(Vertex now, int wayLengthnow, int wayLengthneed)
        {
            int count = 0;
            if (wayLengthnow == wayLengthneed) return 1;
            List<Vertex> list = now.getAdjacentVertexList();
            for (int i = 0; i < list.Count; i++)
            {
                Edge verse = new Edge(now, list[i], -1, -1);
                if (checkForRecCountWays(now, list[i])) continue;

                stackEdge.Add(verse);
                count += recCountWays(list[i], wayLengthnow + 1, wayLengthneed);
                stackEdge.Remove(verse);
            }

            return count;
        }

        public int countWays(Vertex start, int wayLength)
        {
            int count = 0;

            count = recCountWays(start, 0, wayLength);

            return count;
        }

        public int countWays(int wayLength)
        {
            int count = 0;

            for (int i = 0; i < vertexList.Count; i++)
                count += recCountWays(vertexList[i], 0, wayLength);

            return count;
        }

        private bool checkForMaximum_independent_set_of_vertexes(Vertex v, List<Vertex> verList)
        {
            bool f = true;

            for (int i = 0; i < verList.Count; i++)
                if (verList[i].getAdjacentVertexList().Contains(v)) f = false;

            return f;
        }

        public List<Vertex> maximum_independent_set_of_vertexes()
        {
            List<Vertex> res = new List<Vertex>();
            List<Vertex> temp = new List<Vertex>();

            for (int i = 0; i < vertexList.Count; i++)
            {
                temp.Add(vertexList[i]);
                for (int j = 0; j < vertexList.Count; j++)
                {
                    if (i == j) continue;

                    if (checkForMaximum_independent_set_of_vertexes(vertexList[j], temp)) temp.Add(vertexList[j]);
                }
                if (res.Count < temp.Count)
                {
                    res.Clear();
                    foreach (Vertex item in temp) res.Add(item);
                }
                temp.Clear();
            }

            return res;
        }


        public int topology_sort_rec(Vertex now)
        {
            now.setVertexName("gray");
            List<Vertex> list = now.getAdjacentVertexList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].getVertexName() == "gray") return 1;
                if (list[i].getVertexName() == "black") continue;

                if (topology_sort_rec(list[i]) == 1) return 1;
            }
            now.setVertexName("black");
            stackVertex.Add(now);
            return 0;
        }

        public int topology_sort()
        {
            for (int i = 0; i < vertexList.Count; i++) vertexList[i].setVertexName("white");

            if (topology_sort_rec(vertexList[0]) == 1) return 1;
            else
            {
                for (int i = 0; i < vertexList.Count; i++) vertexList[i].setVertexName("");

                int id = 0;
                for (int i = stackVertex.Count - 1; i >= 0; i--)
                {
                    vertexList[id] = stackVertex[i];
                    id++;
                }

                stackVertex.Clear();

                return 0;
            }
        }

        public bool recIsTree(Vertex now, Vertex pred)
        {
            stackVertex.Add(now);
            List<Vertex> list = now.getAdjacentVertexList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == pred) continue;
                if (stackVertex.Contains(list[i])) return false;

                if (recIsTree(list[i], now) == false) return false;
            }

            return true;
        }

        public bool isTree()
        {
            if (recIsTree(vertexList[0], null) == false) return false;

            return true;
        }

        public List<int> BFShortWay(int start)
        {
            List<int> dist = new List<int>(vertexList.Count);

            for (int i = 0; i < vertexList.Count; i++) dist.Add(int.MaxValue);
            dist[start] = 0;

            for (int i = 0; i < vertexList.Count - 1; i++)
            {
                foreach (Edge edge in edgeList)
                {
                    if (dist[edge.GetTransmitterId()] == int.MaxValue) continue;

                    if (dist[edge.GetReceiverId()] > dist[edge.GetTransmitterId()] + edge.GetWeight())
                        dist[edge.GetReceiverId()] = dist[edge.GetTransmitterId()] + edge.GetWeight();
                }
            }

            return dist;
        }
    }

    class Edge
    {
        private Vertex TransmitterVertex, ReceiverVertex;
        private string type; // Types: to, from, both
        private string name;
        private int id;
        private int weight;

        public Edge(Vertex transmitter, Vertex receiver, int newWeight, int newid)
        {
            this.TransmitterVertex = transmitter;
            this.ReceiverVertex = receiver;
            type = "none";
            id = newid;
            weight = newWeight;
        }

        public Edge(Vertex transmitter, Vertex receiver, int newWeight, int newid, string newType)
        {
            this.TransmitterVertex = transmitter;
            this.ReceiverVertex = receiver;
            type = newType;
            id = newid;
            weight = newWeight;
        }

        public int GetWeight()
        {
            return weight;
        }

        public void changeName(string newName)
        {
            name = newName;

        }
        public void changeType(string newType)
        {
            type = newType;
        }

        public void SetTransmitter(Vertex newValue)
        {
            this.TransmitterVertex = newValue;
        }

        public void SetReceiver(Vertex newValue)
        {
            this.ReceiverVertex = newValue;
        }

        public Vertex GetTransmitter()
        {
            return this.TransmitterVertex;
        }

        public int GetTransmitterId()
        {
            return this.TransmitterVertex.getVertexId();
        }

        public Vertex GetReceiver()
        {
            return this.ReceiverVertex;
        }

        public int GetReceiverId()
        {
            return this.ReceiverVertex.getVertexId();
        }

        public void EdgeSetup(Vertex value1, Vertex value2)
        {
            this.TransmitterVertex = value1;
            this.ReceiverVertex = value2;
        }
    };

    class Vertex
    {
        private List<Vertex> adjacentVertexList;
        private string name;
        private int id;

        public Vertex(int newid)
        {
            id = newid;
            name = "";
            adjacentVertexList = new List<Vertex>();
        }

        public Vertex(int newid, string newName)
        {
            id = newid;
            name = newName;
            adjacentVertexList = new List<Vertex>();
        }

        public void addAdjacentVertex(ref Vertex newVertex)
        {
            adjacentVertexList.Add(newVertex);
        }

        public List<Vertex> getAdjacentVertexList()
        {
            return adjacentVertexList;
        }

        public void setVertexName(string newName)
        {
            name = newName;
        }

        public string getVertexName()
        {
            return name;
        }

        public int getVertexId()
        {
            return id;
        }

        public void setVertexId(int newId)
        {
            id = newId;
        }

    }
}
