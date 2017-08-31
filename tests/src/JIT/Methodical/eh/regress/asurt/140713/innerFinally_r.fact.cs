using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_regress_asurt_140713_innerFinally_r_innerFinally_r_
    {
        [Fact]
        public void _eh_regress_asurt_140713_innerFinally_r_innerFinally_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\regress\\asurt\\140713\\innerFinally_r\\innerFinally_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
