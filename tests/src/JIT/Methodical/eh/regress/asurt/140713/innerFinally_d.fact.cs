using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_regress_asurt_140713_innerFinally_d_innerFinally_d_
    {
        [Fact]
        public void _eh_regress_asurt_140713_innerFinally_d_innerFinally_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\regress\\asurt\\140713\\innerFinally_d\\innerFinally_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
