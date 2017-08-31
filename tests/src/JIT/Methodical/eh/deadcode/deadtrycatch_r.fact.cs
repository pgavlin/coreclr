using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_deadtrycatch_r_deadtrycatch_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_deadtrycatch_r_deadtrycatch_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\deadtrycatch_r\\deadtrycatch_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
