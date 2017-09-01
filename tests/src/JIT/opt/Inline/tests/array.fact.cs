using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_array_array_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_array_array_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\array\\array.cmd");
        }
    }
}
