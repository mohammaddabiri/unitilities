﻿using UnityEngine;
using System.Collections;

public static class VectorExtensions
{
    #region Vector2

    /// <summary>
    /// Returns a copy of a vector with a new X field
    /// </summary>
    /// <param name="v">Original vector</param>
    /// <param name="column">X field of the new vector</param>
    /// <returns></returns>
    public static Vector2 WithX(this Vector2 v, float x)
    {
        return new Vector2(x, v.y);
    }

    /// <summary>
    /// Returns a copy of a vector with a new Y field
    /// </summary>
    /// <param name="v">Original vector</param>
    /// <param name="row">Y field of the new vector</param>
    public static Vector2 WithY(this Vector2 v, float y)
    {
        return new Vector2(v.x, y);
    }

    /// <summary>
    /// Returns a copy of a vector with the X field changed by delta
    /// </summary>
    /// <param name="v">Original vector</param>
    /// <param name="delta">Difference in the X field</param>
    /// <returns></returns>
    public static Vector2 AddX(this Vector2 v, float delta)
    {
        return new Vector2(v.x + delta, v.y);
    }

    /// <summary>
    /// Returns a copy of a vector with the Y field changed by delta
    /// </summary>
    /// <param name="v">Original vector</param>
    /// <param name="delta">Difference in the Y field</param>
    /// <returns></returns>
    public static Vector2 AddY(this Vector2 v, float delta)
    {
        return new Vector2(v.x, v.y + delta);
    }

    #endregion


    #region Vector3

    /// <summary>
    /// Returns a copy of a vector with a new X field
    /// </summary>
    /// <param name="v">Original vector</param>
    /// <param name="column">X value of the new vector</param>
    public static Vector3 WithX(this Vector3 v, float x)
    {
        return new Vector3(x, v.y, v.z);
    }

    /// <summary>
    /// Returns a copy of a vector with a new Y field
    /// </summary>
    /// <param name="v">Original vector</param>
    /// <param name="row">Y value of the new vector</param>
    public static Vector3 WithY(this Vector3 v, float y)
    {
        return new Vector3(v.x, y, v.z);
    }

    /// <summary>
    /// Returns a copy of a vector with a new Z field
    /// </summary>
    /// <param name="v">Original vector</param>
    /// <param name="z">Z value of the new vector</param>
    public static Vector3 WithZ(this Vector3 v, float z)
    {
        return new Vector3(v.x, v.y, z);
    }

    /// <summary>
    /// Returns a copy of a vector with the X field changed by delta
    /// </summary>
    /// <param name="v">Original vector</param>
    /// <param name="delta">Difference in the X field</param>
    /// <returns></returns>
    public static Vector3 AddX(this Vector3 v, float delta)
    {
        return new Vector3(v.x + delta, v.y, v.z);
    }

    /// <summary>
    /// Returns a copy of a vector with the Y field changed by delta
    /// </summary>
    /// <param name="v">Original vector</param>
    /// <param name="delta">Difference in the Y field</param>
    /// <returns></returns>
    public static Vector3 AddY(this Vector3 v, float delta)
    {
        return new Vector3(v.x, v.y + delta, v.z);
    }

    /// <summary>
    /// Returns a copy of a vector with the Z field changed by delta
    /// </summary>
    /// <param name="v">Original vector</param>
    /// <param name="delta">Difference in the Z field</param>
    /// <returns></returns>
    public static Vector3 AddZ(this Vector3 v, float delta)
    {
        return new Vector3(v.x, v.y, v.z + delta);
    }
   

    /// <summary>
    /// Returts a Vector2 from a Vector3 by removing the Z field
    /// </summary>
    /// <param name="v"></param>
    /// <returns></returns>
    public static Vector2 ToVector2(this Vector3 v)
    {
        return new Vector2(v.x, v.y);
    }

    #endregion


    #region Vector4

    /// <summary>
    /// Returns a copy of a vector with a new X field
    /// </summary>
    /// <param name="v">Original vector</param>
    /// <param name="column">X field of the new vector</param>
    public static Vector4 WithX(this Vector4 v, float x)
    {
        return new Vector4(x, v.y, v.z);
    }

    /// <summary>
    /// Returns a copy of a vector with a new Y field
    /// </summary>
    /// <param name="v">Original vector</param>
    /// <param name="row">Y field of the new vector</param>
    public static Vector4 WithY(this Vector4 v, float y)
    {
        return new Vector4(v.x, y, v.z);
    }

    /// <summary>
    /// Returns a copy of a vector with a new Z field
    /// </summary>
    /// <param name="v">Original vector</param>
    /// <param name="z">Z field of the new vector</param>
    public static Vector4 WithZ(this Vector4 v, float z)
    {
        return new Vector4(v.x, v.y, z);
    }

    /// <summary>
    /// Returns a copy of a vector with a new W field
    /// </summary>
    /// <param name="v">Original vector</param>
    /// <param name="w">W field of the new vector</param>
    public static Vector4 WithW(this Vector4 v, float w)
    {
        return new Vector4(v.x, v.y, v.z, w);
    }

    /// <summary>
    /// Returns a copy of a vector with the X field changed by delta
    /// </summary>
    /// <param name="v">Original vector</param>
    /// <param name="delta">Difference in the X field</param>
    /// <returns></returns>
    public static Vector4 AddX(this Vector4 v, float delta)
    {
        return new Vector4(v.x + delta, v.y, v.z, v.w);
    }

    /// <summary>
    /// Returns a copy of a vector with the Y field changed by delta
    /// </summary>
    /// <param name="v">Original vector</param>
    /// <param name="delta">Difference in the X field</param>
    /// <returns></returns>
    public static Vector4 AddY(this Vector4 v, float delta)
    {
        return new Vector4(v.x, v.y + delta, v.z, v.w);
    }

    /// <summary>
    /// Returns a copy of a vector with the Z field changed by delta
    /// </summary>
    /// <param name="v">Original vector</param>
    /// <param name="delta">Difference in the X field</param>
    /// <returns></returns>
    public static Vector4 AddZ(this Vector4 v, float delta)
    {
        return new Vector4(v.x, v.y, v.z + delta, v.w);
    }

    /// <summary>
    /// Returns a copy of a vector with the W field changed by delta
    /// </summary>
    /// <param name="v">Original vector</param>
    /// <param name="delta">Difference in the X field</param>
    /// <returns></returns>
    public static Vector4 AddW(this Vector4 v, float delta)
    {
        return new Vector4(v.x, v.y, v.z, v.w + delta);
    }

    /// <summary>
    /// Returts a Vector3 from a Vector2 by removing the W field
    /// </summary>
    /// <param name="v"></param>
    /// <returns></returns>
    public static Vector3 ToVector3(this Vector4 v)
    {
        return new Vector3(v.x, v.y, v.z);
    }

    #endregion
}
