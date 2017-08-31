using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartInt_1_ThreadStartInt_1_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartInt_1_ThreadStartInt_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartInt_1\\ThreadStartInt_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
