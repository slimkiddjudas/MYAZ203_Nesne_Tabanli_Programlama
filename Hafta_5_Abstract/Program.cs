using Hafta_5_Abstract;

MaxHeap maxHeap = new MaxHeap();
maxHeap.Insert(1);
maxHeap.Insert(2);
maxHeap.Insert(3);
maxHeap.Insert(4);
maxHeap.Insert(5);

MinHeap minHeap = new MinHeap();
minHeap.Insert(1);
minHeap.Insert(2);
minHeap.Insert(3);
minHeap.Insert(4);
minHeap.Insert(5);

Console.WriteLine(maxHeap.Extract());
Console.WriteLine(minHeap.Extract());

Console.WriteLine("-------");

foreach (var i in maxHeap.GetList())
{
    Console.WriteLine(i);
}

Console.WriteLine("-------");

foreach (var i in minHeap.GetList())
{
    Console.WriteLine(i);
}