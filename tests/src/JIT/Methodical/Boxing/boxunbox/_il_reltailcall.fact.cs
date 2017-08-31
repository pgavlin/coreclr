using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_boxunbox__il_reltailcall__il_reltailcall_
    {
        [Fact]
        public void _Boxing_boxunbox__il_reltailcall__il_reltailcall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\boxunbox\\_il_reltailcall\\_il_reltailcall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
