using System;
using ObjCRuntime;

public readonly struct NativeHandle : IEquatable<NativeHandle>
{
    private readonly IntPtr handle;

    public static NativeHandle Zero;

    public IntPtr Handle
    {
        get
        {
            throw null;
        }
    }

    unsafe public NativeHandle(IntPtr handle)
    {
        throw null;
    }

    public static bool operator ==(NativeHandle left, IntPtr right)
    {
        throw null;
    }

    public static bool operator ==(NativeHandle left, NativeHandle right)
    {
        throw null;
    }

    public static bool operator ==(IntPtr left, NativeHandle right)
    {
        throw null;
    }

    public static bool operator !=(NativeHandle left, IntPtr right)
    {
        throw null;
    }

    public static bool operator !=(IntPtr left, NativeHandle right)
    {
        throw null;
    }

    public static bool operator !=(NativeHandle left, NativeHandle right)
    {
        throw null;
    }

    public static implicit operator IntPtr(NativeHandle value)
    {
        throw null;
    }

    public static implicit operator NativeHandle(IntPtr value)
    {
        throw null;
    }

    public unsafe static explicit operator void*(NativeHandle value)
    {
        throw null;
    }

    public unsafe static explicit operator NativeHandle(void* value)
    {
        throw null;
    }

    public override bool Equals(object? o)
    {
        throw null;
    }

    public override int GetHashCode()
    {
        throw null;
    }

    public bool Equals(NativeHandle other)
    {
        throw null;
    }

    public override string ToString()
    {
        throw null;
    }
}

