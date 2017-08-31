using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_callconv__relinstance_il__relinstance_il_
    {
        [Fact]
        public void _Boxing_callconv__relinstance_il__relinstance_il_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\callconv\\_relinstance_il\\_relinstance_il.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
