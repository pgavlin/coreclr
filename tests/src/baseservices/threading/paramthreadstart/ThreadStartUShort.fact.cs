using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartUShort_ThreadStartUShort_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartUShort_ThreadStartUShort_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartUShort\\ThreadStartUShort.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
