using System;
using System.Reflection;

namespace System
{
    public static class PropertyHelper
    {
//        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
//         public static Type GetCustomAttributes(this MemberInfo t)
//         {
// #if CORECLR
//             return
//                 t.DeclaringType;
// #else
//             return
//                 t.ReflectedType;
// #endif
//         }
    }

    public static class MemberHelper
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static Type ReflectedType(this MemberInfo t)
        {
#if CORECLR
            return
                t.DeclaringType;
#else
            return
                t.ReflectedType;
#endif
        }
    }

    public static class TypeHelper
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static Assembly Assembly(this Type t)
        {
#if CORECLR
            return
                t.GetTypeInfo().Assembly;
#else
            return
                t.Assembly();
#endif
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static bool HasAttribute(this Type t, Type t2)
        {
#if CORECLR
            return
                t.GetTypeInfo().GetCustomAttribute(t2) != null;
#else
            return
                t.HasAttribute(t2);
#endif
        }

//         [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
//          public static Type[] GetGenericArguments(this Type t)
//          {
//  #if CORECLR
//              return
//                  t.GetTypeInfo().GetGenericArguments();
//  #else
//              return
//                  t.GetGenericArguments();
//  #endif
//          }

//        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
//         public static bool IsAssignableFrom(this Type t, Type t2)
//         {
// #if CORECLR
//             return
//                 t.GetTypeInfo().IsAssignableFrom(t2);
// #else
//             return
//                 t.IsAssignableFrom(t2);
// #endif
//         }

//        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
//         public static Type[] GetInterfaces(this Type t)
//         {
// #if CORECLR
//             return
//                 t.GetTypeInfo().GetInterfaces();
// #else
//             return
//                 t.GetInterfaces();
// #endif
//         }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static Type ReflectedType(this Type t)
        {
#if CORECLR
            return
                t.DeclaringType;
#else
            return
                t.ReflectedType;
#endif
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static bool IsAbstract(this Type t)
        {
#if CORECLR
            return
                t.GetTypeInfo().IsAbstract;
#else
            return
                t.IsAbstract;
#endif
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static bool IsValueType(this Type t)
        {
#if CORECLR
            return
                t.GetTypeInfo().IsValueType;
#else
            return
                t.IsValueType;
#endif
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static bool ContainsGenericParameters(this Type t)
        {
#if CORECLR
            return
                t.GetTypeInfo().ContainsGenericParameters;
#else
            return
                t.ContainsGenericParameters;
#endif
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static bool IsGenericType(this Type t)
        {
#if CORECLR
            return
                t.GetTypeInfo().IsGenericType;
#else
            return
                t.IsGenericType;
#endif
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static bool IsInterface(this Type t)
        {
#if CORECLR
            return
                t.GetTypeInfo().IsInterface;
#else
            return
                t.IsInterface;
#endif
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static Type BaseType(this Type t)
        {
#if CORECLR
            return
                t.GetTypeInfo().BaseType;
#else
            return
                t.BaseType;
#endif
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static bool IsGenericTypeDefinition(this Type t)
        {
#if CORECLR
            return
                t.GetTypeInfo().IsGenericTypeDefinition;
#else
            return
                t.IsGenericTypeDefinition;
#endif
        }
    }
}