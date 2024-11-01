namespace InterviewPreparation.Domain.Entities
{
    public class Queue
    {
        private List<int> queue;

        public Queue() { 
            queue = new List<int>();
        }

        public void Enqueue(int item)
        {
            queue.Add(item);
        }

        public int Dequeue() 
        {
            var value = queue[0];
            queue.RemoveAt(0);
            return value;
        }

        public int Size()
        {
            return queue.Count;
        }

        public List<int> ReadAll()
        {
            return queue;
        }
    }
}
