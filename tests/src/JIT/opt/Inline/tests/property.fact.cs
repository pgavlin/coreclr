using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_property_property_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_property_property_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\property\\property.cmd");
        }
    }
}
