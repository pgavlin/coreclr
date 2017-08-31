using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _waithandle_misc_waithandledispose2_waithandledispose2_
    {
        [OuterLoop]
        [Fact]
        public void _waithandle_misc_waithandledispose2_waithandledispose2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\misc\\waithandledispose2\\waithandledispose2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
