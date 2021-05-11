using System.Collections.Generic;
using UnityEngine;

public static class ListExtensions
{
    public static void AddIfNotNull<T>(this List<T> list, T item)
    {
        if (item != null)
        {
            list.Add(item);
        }
    }

    public static List<T> FilterOut<T, T1>(this List<T> list)
    {
        for (int i = list.Count - 1; i >= 0; i--)
        {
            if (list[i].GetType() == typeof(T1))
            {
                list.RemoveAt(i);
            }
        }

        return list;
    }

    public static List<T> RemoveNull<T>(this List<T> list)
    {
        for (int i = list.Count - 1; i >= 0; i--)
        {
            if (list[i] == null)
            {
                list.RemoveAt(i);
            }
        }

        return list;
    }

    public static void Remove<T>(this List<T> list, List<T> listToRemove)
    {
        foreach (T element in listToRemove)
        {
            list.Remove(element);
        }
    }

    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }
}