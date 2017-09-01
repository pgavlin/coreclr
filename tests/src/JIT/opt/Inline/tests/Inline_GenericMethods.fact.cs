using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_Inline_GenericMethods_Inline_GenericMethods_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_GenericMethods_Inline_GenericMethods_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_GenericMethods\\Inline_GenericMethods.cmd");
        }
    }
}
