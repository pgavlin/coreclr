using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _AssertionPropagation_CPropOverflow_CPropOverflow_
    {
        [OuterLoop]
        [Fact]
        public void _AssertionPropagation_CPropOverflow_CPropOverflow_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\AssertionPropagation\\CPropOverflow\\CPropOverflow.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
