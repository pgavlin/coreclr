using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_branchbackwardswithfinally_d_branchbackwardswithfinally_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_branchbackwardswithfinally_d_branchbackwardswithfinally_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\branchbackwardswithfinally_d\\branchbackwardswithfinally_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
