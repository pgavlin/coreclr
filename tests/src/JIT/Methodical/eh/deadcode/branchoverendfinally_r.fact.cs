using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_branchoverendfinally_r_branchoverendfinally_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_branchoverendfinally_r_branchoverendfinally_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\branchoverendfinally_r\\branchoverendfinally_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
