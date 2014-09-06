﻿using System;
using System.Collections;

public static class Tuples
{
    public static T1 Max<T1>(this Tuple<T1, T1> t) where T1 : IComparable<T1>
    {
        if (t.first.CompareTo(t.second) > 0)
            return t.first;
        else
            return t.second;
    }

    public static T1 Min<T1>(this Tuple<T1, T1> t) where T1 : IComparable<T1>
    {
        if (t.first.CompareTo(t.second) < 0)
            return t.first;
        else
            return t.second;
    }

    public static T1 Max<T1>(this Tuple3<T1, T1, T1> t) where T1 : IComparable<T1>
    {
        if (t.first.CompareTo(t.second) > 0)
            if (t.first.CompareTo(t.third) > 0)
                return t.first;
            else
                return t.third;
        else if (t.second.CompareTo(t.third) > 0)
            return t.second;
        else
            return t.third;
    }

    public static T1 Min<T1>(this Tuple3<T1, T1, T1> t) where T1 : IComparable<T1>
    {
        if (t.first.CompareTo(t.second) < 0)
            if (t.first.CompareTo(t.third) < 0)
                return t.first;
            else
                return t.third;
        else if (t.second.CompareTo(t.third) < 0)
            return t.second;
        else
            return t.third;
    }

    public static T1 Max<T1>(this Tuple4<T1, T1, T1, T1> t) where T1 : IComparable<T1>
    {
        if (t.first.CompareTo(t.second) > 0)
            if (t.first.CompareTo(t.third) > 0)
                if (t.first.CompareTo(t.fourth) > 0)
                    return t.first;
                else
                    return t.fourth;
            else
                if (t.third.CompareTo(t.fourth) > 0)
                    return t.third;
                else
                    return t.fourth;
        else if (t.second.CompareTo(t.third) > 0)
            if (t.second.CompareTo(t.fourth) > 0)
                return t.second;
            else
                return t.fourth;
        else if (t.third.CompareTo(t.fourth) > 0)
            return t.third;
        else
            return t.fourth;
    }

    public static T1 Min<T1>(this Tuple4<T1, T1, T1, T1> t) where T1 : IComparable<T1>
    {
        if (t.first.CompareTo(t.second) < 0)
            if (t.first.CompareTo(t.third) < 0)
                if (t.first.CompareTo(t.fourth) < 0) 
                    return t.first;
                else
                    return t.fourth;
            else
                if (t.third.CompareTo(t.fourth) < 0)
                    return t.third;
                else
                    return t.fourth;
        else if (t.second.CompareTo(t.third) < 0)
            if (t.second.CompareTo(t.fourth) < 0)
                return t.second;
            else
                return t.fourth;
        else if (t.third.CompareTo(t.fourth) < 0)
            return t.third;
        else
            return t.fourth;
    }
}