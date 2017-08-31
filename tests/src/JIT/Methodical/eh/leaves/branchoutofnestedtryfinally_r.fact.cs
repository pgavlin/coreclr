using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_branchoutofnestedtryfinally_r_branchoutofnestedtryfinally_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_branchoutofnestedtryfinally_r_branchoutofnestedtryfinally_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\branchoutofnestedtryfinally_r\\branchoutofnestedtryfinally_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
