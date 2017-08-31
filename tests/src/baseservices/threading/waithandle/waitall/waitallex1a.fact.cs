using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _waithandle_waitall_waitallex1a_waitallex1a_
    {
        [OuterLoop]
        [Fact]
        public void _waithandle_waitall_waitallex1a_waitallex1a_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitall\\waitallex1a\\waitallex1a.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
