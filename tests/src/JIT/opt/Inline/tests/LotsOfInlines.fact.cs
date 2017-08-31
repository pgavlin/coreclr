using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_LotsOfInlines_LotsOfInlines_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_LotsOfInlines_LotsOfInlines_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\LotsOfInlines\\LotsOfInlines.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
