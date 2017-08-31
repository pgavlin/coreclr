using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_boxunbox__il_dbglocal__il_dbglocal_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_boxunbox__il_dbglocal__il_dbglocal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\boxunbox\\_il_dbglocal\\_il_dbglocal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
