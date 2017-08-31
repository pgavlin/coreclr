using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_deadtrycatch_d_deadtrycatch_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_deadtrycatch_d_deadtrycatch_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\deadtrycatch_d\\deadtrycatch_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
