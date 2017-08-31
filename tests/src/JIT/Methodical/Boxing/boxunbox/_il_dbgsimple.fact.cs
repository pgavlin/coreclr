using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_boxunbox__il_dbgsimple__il_dbgsimple_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_boxunbox__il_dbgsimple__il_dbgsimple_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\boxunbox\\_il_dbgsimple\\_il_dbgsimple.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
