using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _waithandle_waitall_waitallex4a_waitallex4a_
    {
        [OuterLoop]
        [Fact]
        public void _waithandle_waitall_waitallex4a_waitallex4a_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitall\\waitallex4a\\waitallex4a.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
