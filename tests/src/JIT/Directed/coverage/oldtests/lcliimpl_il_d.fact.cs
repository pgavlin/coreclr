using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_lcliimpl_il_d_lcliimpl_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_oldtests_lcliimpl_il_d_lcliimpl_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\lcliimpl_il_d\\lcliimpl_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
