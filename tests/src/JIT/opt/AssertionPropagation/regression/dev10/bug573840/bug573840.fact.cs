using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _AssertionPropagation_regression_dev10_bug573840_bug573840_bug573840_
    {
        [OuterLoop]
        [Fact]
        public void _AssertionPropagation_regression_dev10_bug573840_bug573840_bug573840_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\AssertionPropagation\\regression\\dev10\\bug573840\\bug573840\\bug573840.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
