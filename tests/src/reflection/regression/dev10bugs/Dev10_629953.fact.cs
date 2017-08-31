using CoreclrTestLib;
using Xunit;

namespace reflection_regression
{
    class _dev10bugs_Dev10_629953_Dev10_629953_
    {
        [OuterLoop]
        [Fact]
        public void _dev10bugs_Dev10_629953_Dev10_629953_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("reflection\\regression\\dev10bugs\\Dev10_629953\\Dev10_629953.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
