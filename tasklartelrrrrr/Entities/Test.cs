using System;

namespace tasklartelrrrrr.Entities;

public class Test<T>
{
    private T[] _arr;

    public Test()
    {
        _arr = new T[0];
    }

    public void Add(T obj)
    {
        Array.Resize(ref _arr, _arr.Length + 1);
        _arr[_arr.Length - 1] = obj;
    }

    public void ShowAll()
    {
        foreach (var item in _arr)
        {
            Console.WriteLine(item);
        }
    }

    public void Clear()
    {
        Array.Resize(ref _arr, 0);
    }


    public void CustomAddRange(IEnumerable<T> list)
    {
        foreach (var item in list)
        {
            Add(item);
        }
    }

    public bool customContains(T obj)
    {
        foreach (var item in _arr)
        {
            if (Equals(item, obj)) return true;
        }
        return false;
    }

    public int customIndexOf(T obj)
    {
        for (int i = 0; i < _arr.Length; i++)
        {
            if (Equals(_arr[i], obj)) return i;
        }
        return -1;
    }


    public void customRemove(T obj)  // meselen arrayde 3 dene Ulvi varsa hamisin silir 
    {
        for (int i = 0; i <= _arr.Length - 1; i++)
        {
            if (Equals(_arr[i], obj))
            {
                _arr[i] = default;  
                for (int j = i; j < _arr.Length - 1; j++)
                {
                    _arr[j] = _arr[j + 1];
                }
                Array.Resize(ref _arr, _arr.Length - 1);
            }
        }
    }

}
