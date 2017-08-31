using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_indexer_indexer_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_indexer_indexer_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\indexer\\indexer.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
