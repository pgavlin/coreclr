using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_deadnonlocalexit_d_deadnonlocalexit_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_deadnonlocalexit_d_deadnonlocalexit_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\deadnonlocalexit_d\\deadnonlocalexit_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
