using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_ReturnStruct_Method_ReturnStruct_Method_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_ReturnStruct_Method_ReturnStruct_Method_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\ReturnStruct_Method\\ReturnStruct_Method.cmd");
        }
    }
}
