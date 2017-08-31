using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartNull_ThreadStartNull_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartNull_ThreadStartNull_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartNull\\ThreadStartNull.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
