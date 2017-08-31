using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _regressions_V1_SEH_asm_NestedExcept_NestedExcept_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_asm_NestedExcept_NestedExcept_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\asm\\NestedExcept\\NestedExcept.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
