using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_deadtryfinallythrow_r_deadtryfinallythrow_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_deadtryfinallythrow_r_deadtryfinallythrow_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\deadtryfinallythrow_r\\deadtryfinallythrow_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
