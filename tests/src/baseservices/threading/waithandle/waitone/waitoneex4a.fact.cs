using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _waithandle_waitone_waitoneex4a_waitoneex4a_
    {
        [OuterLoop]
        [Fact]
        public void _waithandle_waitone_waitoneex4a_waitoneex4a_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitone\\waitoneex4a\\waitoneex4a.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
