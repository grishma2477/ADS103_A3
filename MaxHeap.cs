using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS103_Grishma_A00177960_Assignment3
{
    // A MaxHeap implementation for Employee objects based on salary
    class MaxHeap
    {
        private List<Employee> heap = new List<Employee>();

        // Insert a new employee into the heap
        public void Insert(Employee employee)
        {
            heap.Add(employee);
            HeapifyUp(heap.Count - 1);
        }

        // Remove and return the employee with the highest salary
        public Employee ExtractMax()
        {
            if (heap.Count == 0) return null;

            Employee max = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            HeapifyDown(0);
            return max;
        }

        // Check if heap is empty
        public bool IsEmpty() => heap.Count == 0;

        // Move the newly added employee up to restore heap property
        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parent = (index - 1) / 2;
                if (heap[index].GetSalary() <= heap[parent].GetSalary()) break;
                Swap(index, parent);
                index = parent;
            }
        }

        // Move the top element down to restore heap property
        private void HeapifyDown(int index)
        {
            int lastIndex = heap.Count - 1;
            while (index < heap.Count)
            {
                int left = 2 * index + 1;
                int right = 2 * index + 2;
                int largest = index;

                if (left <= lastIndex && heap[left].GetSalary() > heap[largest].GetSalary()) largest = left;
                if (right <= lastIndex && heap[right].GetSalary() > heap[largest].GetSalary()) largest = right;
                if (largest == index) break;

                Swap(index, largest);
                index = largest;
            }
        }

        // Swap two employees in the heap
        private void Swap(int i, int j)
        {
            var temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }
    }
}
