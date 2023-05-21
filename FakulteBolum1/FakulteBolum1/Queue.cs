using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakulteBolum1
{
    class Queue
    {
        public readonly Student[] arr;

        private int rear = -1;
        public Queue(int capacity) => arr = new Student[capacity];

        public void Enqueue(Student data)
        {
            arr[++rear] = data;
        }
    }
}
