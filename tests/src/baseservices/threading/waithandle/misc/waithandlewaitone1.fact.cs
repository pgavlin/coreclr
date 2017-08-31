using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _waithandle_misc_waithandlewaitone1_waithandlewaitone1_
    {
        [OuterLoop]
        [Fact]
        public void _waithandle_misc_waithandlewaitone1_waithandlewaitone1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\misc\\waithandlewaitone1\\waithandlewaitone1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
