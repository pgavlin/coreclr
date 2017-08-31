using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _mutex_abandonedmutex_am02waitoneneg_am02waitoneneg_
    {
        [OuterLoop]
        [Fact]
        public void _mutex_abandonedmutex_am02waitoneneg_am02waitoneneg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\abandonedmutex\\am02waitoneneg\\am02waitoneneg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
