using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartDelegate_ThreadStartDelegate_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartDelegate_ThreadStartDelegate_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartDelegate\\ThreadStartDelegate.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
