using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_size_size_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_size_size_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\size\\size.cmd");
        }
    }
}
