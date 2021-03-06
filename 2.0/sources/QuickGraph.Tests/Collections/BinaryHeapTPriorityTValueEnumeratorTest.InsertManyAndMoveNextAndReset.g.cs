// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using System.Collections.Generic;
using QuickGraph.Unit;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph.Collections
{
    public partial class BinaryHeapTPriorityTValueEnumeratorTest
    {
        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueEnumeratorTest))]
        public void InsertManyAndMoveNextAndReset01()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(0);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
            this.InsertManyAndMoveNextAndReset<int, int>(binaryHeap, keyValuePairs);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueEnumeratorTest))]
        public void InsertManyAndMoveNextAndReset02()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(1);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
            this.InsertManyAndMoveNextAndReset<int, int>(binaryHeap, keyValuePairs);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueEnumeratorTest))]
        public void InsertManyAndMoveNextAndReset03()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(0);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
            this.InsertManyAndMoveNextAndReset<int, int>(binaryHeap, keyValuePairs);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueEnumeratorTest))]
        public void InsertManyAndMoveNextAndReset04()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(1);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            this.InsertManyAndMoveNextAndReset<int, int>(binaryHeap, keyValuePairs);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueEnumeratorTest))]
        public void InsertManyAndMoveNextAndReset05()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(0);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            this.InsertManyAndMoveNextAndReset<int, int>(binaryHeap, keyValuePairs);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueEnumeratorTest))]
        public void InsertManyAndMoveNextAndReset06()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(2);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            this.InsertManyAndMoveNextAndReset<int, int>(binaryHeap, keyValuePairs);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueEnumeratorTest))]
        public void InsertManyAndMoveNextAndReset07()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(3);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[3];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(2119361876, default(int))
              ;
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(2119361876, default(int))
              ;
            keyValuePairs[1] = s1;
            KeyValuePair<int, int> s2 = new KeyValuePair<int, int>(2119361876, default(int))
              ;
            keyValuePairs[2] = s2;
            this.InsertManyAndMoveNextAndReset<int, int>(binaryHeap, keyValuePairs);
        }

    }
}
