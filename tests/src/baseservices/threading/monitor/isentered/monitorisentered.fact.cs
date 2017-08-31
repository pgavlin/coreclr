using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _monitor_isentered_monitorisentered_monitorisentered_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_isentered_monitorisentered_monitorisentered_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\isentered\\monitorisentered\\monitorisentered.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
