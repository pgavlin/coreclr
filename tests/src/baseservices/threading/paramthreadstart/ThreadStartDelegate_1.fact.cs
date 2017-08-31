using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartDelegate_1_ThreadStartDelegate_1_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartDelegate_1_ThreadStartDelegate_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartDelegate_1\\ThreadStartDelegate_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
