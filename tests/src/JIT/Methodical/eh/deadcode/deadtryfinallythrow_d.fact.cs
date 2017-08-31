using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_deadtryfinallythrow_d_deadtryfinallythrow_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_deadtryfinallythrow_d_deadtryfinallythrow_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\deadtryfinallythrow_d\\deadtryfinallythrow_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
