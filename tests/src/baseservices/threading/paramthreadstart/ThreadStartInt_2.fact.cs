using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartInt_2_ThreadStartInt_2_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartInt_2_ThreadStartInt_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartInt_2\\ThreadStartInt_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
