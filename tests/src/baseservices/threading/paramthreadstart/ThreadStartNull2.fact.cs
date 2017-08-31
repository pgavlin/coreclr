using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartNull2_ThreadStartNull2_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartNull2_ThreadStartNull2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartNull2\\ThreadStartNull2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
