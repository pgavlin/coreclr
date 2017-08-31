using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_assemblynameflags_AssemblyNameFlagsRetargetable_AssemblyNameFlagsRetargetable_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_assemblynameflags_AssemblyNameFlagsRetargetable_AssemblyNameFlagsRetargetable_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\assemblynameflags\\AssemblyNameFlagsRetargetable\\AssemblyNameFlagsRetargetable.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
