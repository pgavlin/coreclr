using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_regress_asurt_140713_innerFinally_do_innerFinally_do_
    {
        [Fact]
        public void _eh_regress_asurt_140713_innerFinally_do_innerFinally_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\regress\\asurt\\140713\\innerFinally_do\\innerFinally_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
