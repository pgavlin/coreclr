using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_indexer_indexer_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_indexer_indexer_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\indexer\\indexer.cmd");
        }
    }
}
