using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_deadcodeincatch_d_deadcodeincatch_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_deadcodeincatch_d_deadcodeincatch_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\deadcodeincatch_d\\deadcodeincatch_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
