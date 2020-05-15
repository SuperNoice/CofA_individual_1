using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace individual
{
    class Graph
    {
        private List<Vertex> vertexList;
        private List<Edge> edgeList;
        public string name { get; set; }
        private List<Edge> stack;

        public Graph()
        {
            vertexList = new List<Vertex>();
            edgeList = new List<Edge>();
            stack = new List<Edge>();
            name = "";
        }

        public Graph(string newName)
        {
            vertexList = new List<Vertex>();
            edgeList = new List<Edge>();
            stack = new List<Edge>();
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
                    if (matrSm[i, j] > 0 && matrSm[j, i] < 0) type = "to";
                    if (matrSm[i, j] < 0 && matrSm[j, i] > 0) type = "from";

                    if (matrSm[i, j] != 0)
                        addEdge(vertexList[i], vertexList[j], type);
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

        public Edge addEdge(Vertex transmitter, Vertex reciver, string Type)
        {
            Edge newEdge = new Edge(transmitter, reciver, edgeList.Count(), Type);
            edgeList.Add(newEdge);

            if (Type == "both")
            {
                if (!reciver.getAdjacentVertexList().Contains(transmitter))
                    reciver.addAdjacentVertex(ref transmitter);
                if (!transmitter.getAdjacentVertexList().Contains(reciver))
                    transmitter.addAdjacentVertex(ref reciver);
            }
            if (Type == "to")
            {
                if (!transmitter.getAdjacentVertexList().Contains(reciver))
                    transmitter.addAdjacentVertex(ref reciver);
            }
            if (Type == "from")
            {
                if (!reciver.getAdjacentVertexList().Contains(transmitter))
                    reciver.addAdjacentVertex(ref transmitter);
            }
            return newEdge;
        }

        public Edge addEdge(string Type)
        {
            Vertex transmitter = new Vertex(vertexList.Count());
            vertexList.Add(transmitter);
            Vertex reciver = new Vertex(vertexList.Count());
            vertexList.Add(reciver);
            Edge newEdge = new Edge(transmitter, reciver, edgeList.Count(), Type);
            edgeList.Add(newEdge);

            if (Type == "both")
            {
                if (!reciver.getAdjacentVertexList().Contains(transmitter))
                    reciver.addAdjacentVertex(ref transmitter);
                if (!transmitter.getAdjacentVertexList().Contains(reciver))
                    transmitter.addAdjacentVertex(ref reciver);
            }
            if (Type == "to")
            {
                if (!transmitter.getAdjacentVertexList().Contains(reciver))
                    transmitter.addAdjacentVertex(ref reciver);
            }
            if (Type == "from")
            {
                if (!reciver.getAdjacentVertexList().Contains(transmitter))
                    reciver.addAdjacentVertex(ref transmitter);
            }
            return newEdge;
        }

        private bool check(Vertex now, Vertex next)
        {
            bool f = false;
            for (int i = 0; i < stack.Count; i++)
                if ((stack[i].GetTransmitter().GetHashCode() == now.GetHashCode() && stack[i].GetReceiver().GetHashCode() == next.GetHashCode()) || (stack[i].GetTransmitter().GetHashCode() == next.GetHashCode() && stack[i].GetReceiver().GetHashCode() == now.GetHashCode()))
                    f = true;

            return f;
        }
        private int recCountWays(Vertex now, int wayleghtnow, int wayleghtneed)
        {
            int count = 0;
            if (wayleghtnow == wayleghtneed) return 1;
            List<Vertex> list = now.getAdjacentVertexList();
            for (int i = 0; i < list.Count; i++)
            {
                Edge verse = new Edge(now, list[i], -1);
                if (check(now, list[i])) continue;

                stack.Add(verse);
                count += recCountWays(list[i], wayleghtnow + 1, wayleghtneed);
                stack.Remove(verse);
            }

            return count;
        }

        public int countWays(Vertex start, int wayLeght)
        {
            int count = 0;

            count = recCountWays(start, 0, wayLeght);

            return count;
        }

        public int countWays(int wayLeght)
        {
            int count = 0;

            for (int i = 0; i < vertexList.Count; i++)
                count += recCountWays(vertexList[i], 0, wayLeght);

            return count;
        }
    }

    class Edge
    {
        private Vertex TransmitterVertex, ReceiverVertex;
        private string type; // Types: to, from, both
        private string name;
        private int id;

        public Edge(Vertex transmitter, Vertex receiver, int newid)
        {
            this.TransmitterVertex = transmitter;
            this.ReceiverVertex = receiver;
            type = "none";
            id = newid;
        }

        public Edge(Vertex transmitter, Vertex receiver, int newid, string newType)
        {
            this.TransmitterVertex = transmitter;
            this.ReceiverVertex = receiver;
            type = newType;
            id = newid;
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

        public Vertex GetReceiver()
        {
            return this.ReceiverVertex;
        }

        public void EdgeSetup(Vertex value1, Vertex value2)
        {
            this.TransmitterVertex = value1;
            this.ReceiverVertex = value2;
        }
    };

    struct Vertex
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

    }
}
