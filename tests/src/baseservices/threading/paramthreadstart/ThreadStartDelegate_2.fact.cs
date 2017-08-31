using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartDelegate_2_ThreadStartDelegate_2_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartDelegate_2_ThreadStartDelegate_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartDelegate_2\\ThreadStartDelegate_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
