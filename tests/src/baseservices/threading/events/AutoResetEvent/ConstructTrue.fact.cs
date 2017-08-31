using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _events_AutoResetEvent_ConstructTrue_ConstructTrue_
    {
        [OuterLoop]
        [Fact]
        public void _events_AutoResetEvent_ConstructTrue_ConstructTrue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\events\\AutoResetEvent\\ConstructTrue\\ConstructTrue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
