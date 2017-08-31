using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_boxunbox__il_dbgtry__il_dbgtry_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_boxunbox__il_dbgtry__il_dbgtry_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\boxunbox\\_il_dbgtry\\_il_dbgtry.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
