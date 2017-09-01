using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_StructInClass_StructInClass_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_StructInClass_StructInClass_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\StructInClass\\StructInClass.cmd");
        }
    }
}
