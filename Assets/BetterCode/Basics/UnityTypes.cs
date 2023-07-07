using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityTypes : MonoBehaviour
{
    public bool boolType;
    public object objectType;
    public string stringType;

    public byte byteTypeMin;
    public byte byteTypeMax;
    public sbyte sbyteTypeMin;
    public sbyte sbyteTypeMax;
    public char charTypeMin;
    public char charTypeMax;
    public decimal decimalTypeMin;
    public decimal decimalTypeMax;
    public double doubleTypeMin;
    public double doubleTypeMax;
    public float floatTypeMin;
    public float floatTypeMax;
    public int intTypeMin;
    public int intTypeMax;
    public uint uintTypeMin;
    public uint uintTypeMax;
    public long longTypeMin;
    public long longTypeMax;
    public ulong ulongTypeMin;
    public ulong ulongTypeMax;
    public short shortTypeMin;
    public short shortTypeMax;
    public ushort ushortTypeMin;
    public ushort ushortTypeMax;

    private void Awake()
    {
        byteTypeMax = Byte.MaxValue;
        sbyteTypeMax = sbyte.MaxValue;
        charTypeMax = Char.MaxValue;
        decimalTypeMax = Decimal.MaxValue;
        doubleTypeMax = Double.MaxValue;
        floatTypeMax = float.MaxValue;
        intTypeMax = int.MaxValue;
        uintTypeMax = UInt32.MaxValue;
        longTypeMax = long.MaxValue;
        ulongTypeMax = ulong.MaxValue;
        shortTypeMax = short.MaxValue;
        ushortTypeMax = ushort.MaxValue;

        byteTypeMin = Byte.MinValue;
        sbyteTypeMin = sbyte.MinValue;
        charTypeMin = Char.MinValue;
        decimalTypeMin = Decimal.MinValue;
        doubleTypeMin = Double.MinValue;
        floatTypeMin = float.MinValue;
        intTypeMin = int.MinValue;
        uintTypeMin = UInt32.MinValue;
        longTypeMin = long.MinValue;
        ulongTypeMin = ulong.MinValue;
        shortTypeMin = short.MinValue;
        ushortTypeMin = ushort.MinValue;
    }
}