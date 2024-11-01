using InterviewPreparation.Domain.Entities;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Domain.Entities
{
    public class QueueTests
    {
        [Fact]
        public void CreateQueue()
        {
            var queue = new Queue();
            queue.Enqueue(61);
            queue.Enqueue(43);
            queue.Enqueue(89);
            queue.Dequeue();
            queue.Enqueue(16);
            queue.Enqueue(51);
            queue.Dequeue();
            queue.Enqueue(66);
            queue.Dequeue();
            queue.Enqueue(11);
            queue.Enqueue(32);
            queue.Dequeue();
            queue.Enqueue(55);
            queue.Dequeue();
            queue.Enqueue(79);
            queue.Dequeue();

            Assert.Equal(4, queue.Size());
            var items = queue.ReadAll();
            Assert.Equal(11, items[0]);
            Assert.Equal(32, items[1]);
            Assert.Equal(55, items[2]);
            Assert.Equal(79, items[3]);
        }
    }
}
