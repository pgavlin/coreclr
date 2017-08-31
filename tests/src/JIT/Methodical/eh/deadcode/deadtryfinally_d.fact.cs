using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_deadtryfinally_d_deadtryfinally_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_deadtryfinally_d_deadtryfinally_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\deadtryfinally_d\\deadtryfinally_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
