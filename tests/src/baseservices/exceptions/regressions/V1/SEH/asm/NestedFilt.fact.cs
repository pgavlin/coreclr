using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _regressions_V1_SEH_asm_NestedFilt_NestedFilt_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_asm_NestedFilt_NestedFilt_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\asm\\NestedFilt\\NestedFilt.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
