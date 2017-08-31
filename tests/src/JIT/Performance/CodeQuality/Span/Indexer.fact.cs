using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_Span_Indexer_Indexer_
    {
        [Fact]
        public void _CodeQuality_Span_Indexer_Indexer_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\Span\\Indexer\\Indexer.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
