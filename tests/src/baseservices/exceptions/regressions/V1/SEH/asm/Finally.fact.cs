using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _regressions_V1_SEH_asm_Finally_Finally_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_asm_Finally_Finally_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\asm\\Finally\\Finally.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
