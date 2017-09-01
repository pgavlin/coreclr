using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_Inline_DelegateStruct_Inline_DelegateStruct_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_DelegateStruct_Inline_DelegateStruct_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_DelegateStruct\\Inline_DelegateStruct.cmd");
        }
    }
}
