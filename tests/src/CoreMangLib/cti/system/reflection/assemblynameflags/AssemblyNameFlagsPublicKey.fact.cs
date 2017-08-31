using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_assemblynameflags_AssemblyNameFlagsPublicKey_AssemblyNameFlagsPublicKey_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_assemblynameflags_AssemblyNameFlagsPublicKey_AssemblyNameFlagsPublicKey_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\assemblynameflags\\AssemblyNameFlagsPublicKey\\AssemblyNameFlagsPublicKey.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
