using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_interfaceproperty_interfaceproperty_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_interfaceproperty_interfaceproperty_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\interfaceproperty\\interfaceproperty.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
