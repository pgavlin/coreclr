using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartUShort_2_ThreadStartUShort_2_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartUShort_2_ThreadStartUShort_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartUShort_2\\ThreadStartUShort_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
