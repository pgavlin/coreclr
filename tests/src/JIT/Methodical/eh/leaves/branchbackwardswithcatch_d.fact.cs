using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_branchbackwardswithcatch_d_branchbackwardswithcatch_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_branchbackwardswithcatch_d_branchbackwardswithcatch_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\branchbackwardswithcatch_d\\branchbackwardswithcatch_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
