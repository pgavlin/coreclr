using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_assemblyname_AssemblyNameGetPublicKeyToken_AssemblyNameGetPublicKeyToken_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_assemblyname_AssemblyNameGetPublicKeyToken_AssemblyNameGetPublicKeyToken_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\assemblyname\\AssemblyNameGetPublicKeyToken\\AssemblyNameGetPublicKeyToken.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
