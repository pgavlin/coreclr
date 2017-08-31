using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_StructInClass_StructInClass_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_StructInClass_StructInClass_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\StructInClass\\StructInClass.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
