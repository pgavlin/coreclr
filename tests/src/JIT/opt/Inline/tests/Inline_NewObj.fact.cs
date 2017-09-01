using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_Inline_NewObj_Inline_NewObj_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_NewObj_Inline_NewObj_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_NewObj\\Inline_NewObj.cmd");
        }
    }
}
