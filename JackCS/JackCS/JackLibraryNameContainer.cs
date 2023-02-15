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
        public override string Linux => "libjack.so";

        /// <inheritdoc />
        public override string MacOS => "libjack.dylib";

        /// <inheritdoc />
        public override string Android => "libjack.so";

        /// <inheritdoc />
        public override string IOS => "libjack.dylib";

        /// <inheritdoc />
        public override string Windows64 => "libjack.dll";

        /// <inheritdoc />
        public override string Windows86 => "libjack.dll";
    }
}
