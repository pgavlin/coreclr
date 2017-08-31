using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_branchoverendfinally_d_branchoverendfinally_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_branchoverendfinally_d_branchoverendfinally_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\branchoverendfinally_d\\branchoverendfinally_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
