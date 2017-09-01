using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_ArrayOfStructs_ArrayOfStructs_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_ArrayOfStructs_ArrayOfStructs_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\ArrayOfStructs\\ArrayOfStructs.cmd");
        }
    }
}
