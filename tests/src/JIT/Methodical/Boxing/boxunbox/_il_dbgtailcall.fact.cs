using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_boxunbox__il_dbgtailcall__il_dbgtailcall_
    {
        [Fact]
        public void _Boxing_boxunbox__il_dbgtailcall__il_dbgtailcall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\boxunbox\\_il_dbgtailcall\\_il_dbgtailcall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
