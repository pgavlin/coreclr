using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _events_AutoResetEvent_ConstructFalse_ConstructFalse_
    {
        [OuterLoop]
        [Fact]
        public void _events_AutoResetEvent_ConstructFalse_ConstructFalse_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\events\\AutoResetEvent\\ConstructFalse\\ConstructFalse.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
