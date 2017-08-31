using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartShort_2_ThreadStartShort_2_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartShort_2_ThreadStartShort_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartShort_2\\ThreadStartShort_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
