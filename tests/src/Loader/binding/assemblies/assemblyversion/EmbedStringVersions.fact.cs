using CoreclrTestLib;
using Xunit;

namespace Loader_binding
{
    class _assemblies_assemblyversion_EmbedStringVersions_EmbedStringVersions_
    {
        [OuterLoop]
        [Fact]
        public void _assemblies_assemblyversion_EmbedStringVersions_EmbedStringVersions_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\binding\\assemblies\\assemblyversion\\EmbedStringVersions\\EmbedStringVersions.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
