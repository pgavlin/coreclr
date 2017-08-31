using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartShort_ThreadStartShort_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartShort_ThreadStartShort_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartShort\\ThreadStartShort.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
