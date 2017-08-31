using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _waithandle_waitall_waitallex2a_waitallex2a_
    {
        [OuterLoop]
        [Fact]
        public void _waithandle_waitall_waitallex2a_waitallex2a_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitall\\waitallex2a\\waitallex2a.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
