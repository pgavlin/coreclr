using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_GenericStructs_GenericStructs_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_GenericStructs_GenericStructs_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\GenericStructs\\GenericStructs.cmd");
        }
    }
}
