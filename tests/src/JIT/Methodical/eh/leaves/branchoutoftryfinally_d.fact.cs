using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_branchoutoftryfinally_d_branchoutoftryfinally_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_branchoutoftryfinally_d_branchoutoftryfinally_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\branchoutoftryfinally_d\\branchoutoftryfinally_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
