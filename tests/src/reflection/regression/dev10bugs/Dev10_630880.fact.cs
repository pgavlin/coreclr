using CoreclrTestLib;
using Xunit;

namespace reflection_regression
{
    class _dev10bugs_Dev10_630880_Dev10_630880_
    {
        [OuterLoop]
        [Fact]
        public void _dev10bugs_Dev10_630880_Dev10_630880_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("reflection\\regression\\dev10bugs\\Dev10_630880\\Dev10_630880.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
