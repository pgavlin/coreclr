using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_assemblyname_AssemblyNameSetPublicKeyToken_AssemblyNameSetPublicKeyToken_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_assemblyname_AssemblyNameSetPublicKeyToken_AssemblyNameSetPublicKeyToken_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\assemblyname\\AssemblyNameSetPublicKeyToken\\AssemblyNameSetPublicKeyToken.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
