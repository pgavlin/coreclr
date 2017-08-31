using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartInt_ThreadStartInt_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartInt_ThreadStartInt_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartInt\\ThreadStartInt.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
