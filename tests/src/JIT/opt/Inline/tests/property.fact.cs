using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_property_property_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_property_property_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\property\\property.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
