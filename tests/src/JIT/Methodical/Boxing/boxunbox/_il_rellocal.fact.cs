using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_boxunbox__il_rellocal__il_rellocal_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_boxunbox__il_rellocal__il_rellocal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\boxunbox\\_il_rellocal\\_il_rellocal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
