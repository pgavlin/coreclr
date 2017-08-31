using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_assemblynameflags_AssemblyNameFlagsNone_AssemblyNameFlagsNone_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_assemblynameflags_AssemblyNameFlagsNone_AssemblyNameFlagsNone_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\assemblynameflags\\AssemblyNameFlagsNone\\AssemblyNameFlagsNone.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
