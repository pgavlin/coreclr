using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_branchoutoftryfinally_r_branchoutoftryfinally_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_branchoutoftryfinally_r_branchoutoftryfinally_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\branchoutoftryfinally_r\\branchoutoftryfinally_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
