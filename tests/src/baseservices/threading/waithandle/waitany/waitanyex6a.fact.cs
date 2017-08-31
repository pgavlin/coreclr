using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _waithandle_waitany_waitanyex6a_waitanyex6a_
    {
        [OuterLoop]
        [Fact]
        public void _waithandle_waitany_waitanyex6a_waitanyex6a_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitany\\waitanyex6a\\waitanyex6a.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
