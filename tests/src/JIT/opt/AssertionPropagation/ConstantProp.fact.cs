using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _AssertionPropagation_ConstantProp_ConstantProp_
    {
        [OuterLoop]
        [Fact]
        public void _AssertionPropagation_ConstantProp_ConstantProp_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\AssertionPropagation\\ConstantProp\\ConstantProp.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
