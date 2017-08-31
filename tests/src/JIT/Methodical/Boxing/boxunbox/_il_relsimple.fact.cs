using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_boxunbox__il_relsimple__il_relsimple_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_boxunbox__il_relsimple__il_relsimple_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\boxunbox\\_il_relsimple\\_il_relsimple.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
