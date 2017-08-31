using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _unittests_GoryNativePast_GoryNativePast_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_GoryNativePast_GoryNativePast_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\GoryNativePast\\GoryNativePast.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
