using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _waithandle_waitall_waitallemptyarray_waitallemptyarray_
    {
        [OuterLoop]
        [Fact]
        public void _waithandle_waitall_waitallemptyarray_waitallemptyarray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitall\\waitallemptyarray\\waitallemptyarray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
