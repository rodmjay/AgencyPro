#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System;
using System.ComponentModel;

namespace AgencyPro.Common.Extensions;

public static class EnumExtensions
    // ReSharper restore CheckNamespace
{
    public static string GetDescription(this Enum value)
    {
        var field = value.GetType().GetField(value.ToString());

        var attributes = (DescriptionAttribute[]) field.GetCustomAttributes(typeof(DescriptionAttribute), false);

        return attributes.Length > 0 ? attributes[0].Description : value.ToString();
    }

    public static string GetName(this Enum value)
    {
        var field = value.GetType().GetField(value.ToString());
        return field.Name;
    }


    public static bool Has<T>(this Enum type, T value)
    {
        try
        {
            return ((int)(object)type & (int)(object)value) == (int)(object)value;
        }
        catch
        {
            return false;
        }
    }

    public static bool Is<T>(this Enum type, T value)
    {
        try
        {
            return (int)(object)type == (int)(object)value;
        }
        catch
        {
            return false;
        }
    }


    public static T Add<T>(this Enum type, T value)
    {
        try
        {
            return (T)(object)((int)(object)type | (int)(object)value);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(
                string.Format(
                    "Could not append value from enumerated type '{0}'.",
                    typeof(T).Name
                ), ex);
        }
    }


    public static T Remove<T>(this Enum type, T value)
    {
        try
        {
            return (T)(object)((int)(object)type & ~(int)(object)value);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(
                string.Format(
                    "Could not remove value from enumerated type '{0}'.",
                    typeof(T).Name
                ), ex);
        }
    }
}