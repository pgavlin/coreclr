using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartUShort_1_ThreadStartUShort_1_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartUShort_1_ThreadStartUShort_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartUShort_1\\ThreadStartUShort_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
