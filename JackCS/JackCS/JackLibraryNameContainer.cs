//oh

using Silk.NET.Core.Loader;

namespace JackCS
{
    /// <summary>
    /// Contains the library name of jack.
    /// </summary>
    internal class JackLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libjack.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libjack.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libjack.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "libjack.dylib" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "libjack.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "libjack.dll" };
    }
}
