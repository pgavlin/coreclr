using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_functional__relfibo_il__relfibo_il_
    {
        [Fact]
        public void _Boxing_functional__relfibo_il__relfibo_il_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\functional\\_relfibo_il\\_relfibo_il.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
