using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_assemblyname_AssemblyNameGetPublicKey_AssemblyNameGetPublicKey_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_assemblyname_AssemblyNameGetPublicKey_AssemblyNameGetPublicKey_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\assemblyname\\AssemblyNameGetPublicKey\\AssemblyNameGetPublicKey.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
