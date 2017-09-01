using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_LotsOfInlines_LotsOfInlines_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_LotsOfInlines_LotsOfInlines_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\LotsOfInlines\\LotsOfInlines.cmd");
        }
    }
}
