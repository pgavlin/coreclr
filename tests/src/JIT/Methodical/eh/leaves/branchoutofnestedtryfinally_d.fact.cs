using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_branchoutofnestedtryfinally_d_branchoutofnestedtryfinally_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_branchoutofnestedtryfinally_d_branchoutofnestedtryfinally_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\branchoutofnestedtryfinally_d\\branchoutofnestedtryfinally_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
