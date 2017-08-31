using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _AssertionPropagation_CopyProp_CopyProp_
    {
        [OuterLoop]
        [Fact]
        public void _AssertionPropagation_CopyProp_CopyProp_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\AssertionPropagation\\CopyProp\\CopyProp.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
