using System;

namespace OneOf {
    internal static class Functions {
        internal static string FormatValue<T>(T value) => $"{typeof(T).FullName}: {value?.ToString()}";
        internal static string FormatValue<T>(object @this, object @base, T value) => 
            ReferenceEquals(@this, value) ? 
                @base.ToString() : 
                $"{typeof(T).FullName}: {value?.ToString()}";
    }
}
