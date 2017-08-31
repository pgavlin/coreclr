using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_boxunbox__il_dbgchain__il_dbgchain_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_boxunbox__il_dbgchain__il_dbgchain_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\boxunbox\\_il_dbgchain\\_il_dbgchain.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
