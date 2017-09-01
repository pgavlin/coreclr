using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_interfaceproperty_interfaceproperty_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_interfaceproperty_interfaceproperty_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\interfaceproperty\\interfaceproperty.cmd");
        }
    }
}
