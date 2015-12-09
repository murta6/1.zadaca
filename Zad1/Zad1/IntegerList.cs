using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class IntegerList : IIntegerList
    {
        /// <summary>
        /// The actual storage for IntegerList.
        /// </summary>
        private int[] _internalStorage;
        /// <summary>
        /// Size with which the IntegerList was inititated.
        /// </summary>
        private int _initialSize;
        /// <summary>
        /// Current number of elements in the list.
        /// </summary>
        private int _size;
        /// <summary>
        /// Default constructor for IntegerList which initiates list with capacity of 4.
        /// </summary>
        public IntegerList() : this(4)
        {
        }
        /// <summary>
        /// Constructor for IntegerList which initiates list with specified capacity.7
        /// </summary>
        public IntegerList(int initialSize)
        {
            _initialSize = initialSize;
            _size = 0;
            _internalStorage = new int[initialSize];
        }
        public int Count()
        {
            return _size;
        }

        public void Add(int item)
        {
            if (_size == _internalStorage.Length)
            {
                rearrange();
            }
            _internalStorage[_size] = item;
            _size++;
        }

        private void rearrange()
        {
            int[] temp = new int[_internalStorage.Length * 2];
            for(int i = 0; i < _internalStorage.Length; i++)
            {
                temp[i] = _internalStorage[i];
            }
            _internalStorage = temp;
        }

        public void Clear()
        {
            _internalStorage = new int[_initialSize];
            _size = 0;
        }

        public bool Contains(int item)
        {
            for(int i = 0; i < _internalStorage.Length; i++)
            {
                if(_internalStorage[i] == item)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetElement(int index)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < _internalStorage.Length; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Remove(int item)
        {
            for (int i = 0; i < _internalStorage.Length; i++)
            {
                if (_internalStorage[i] == item)
                {
                    //TODO
                    return true;
                }
            }
            return false;
        }

        public bool RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}
