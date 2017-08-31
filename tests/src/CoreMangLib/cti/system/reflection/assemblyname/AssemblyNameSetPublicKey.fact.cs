using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_assemblyname_AssemblyNameSetPublicKey_AssemblyNameSetPublicKey_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_assemblyname_AssemblyNameSetPublicKey_AssemblyNameSetPublicKey_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\assemblyname\\AssemblyNameSetPublicKey\\AssemblyNameSetPublicKey.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
