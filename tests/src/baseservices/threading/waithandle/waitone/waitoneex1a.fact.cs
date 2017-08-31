using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _waithandle_waitone_waitoneex1a_waitoneex1a_
    {
        [OuterLoop]
        [Fact]
        public void _waithandle_waitone_waitoneex1a_waitoneex1a_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitone\\waitoneex1a\\waitoneex1a.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
