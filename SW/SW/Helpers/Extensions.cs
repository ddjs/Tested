namespace SW.Helpers
{
    using System;

    /// <summary>
    /// The extensions.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Converts a string to its ENUM Value if it can.
        /// </summary>
        /// <param name="source">
        /// The source string to convert.
        /// </param>
        /// <typeparam name="T">
        /// The type of ENUM
        /// </typeparam>
        /// <returns>
        /// The <see cref="T"/>.
        /// The enum value.
        /// </returns>
        public static T ToEnum<T>(this string source) where T : struct
        {
            T result;
            Enum.TryParse(source, true, out result);
            return result;
        }
    }
}
