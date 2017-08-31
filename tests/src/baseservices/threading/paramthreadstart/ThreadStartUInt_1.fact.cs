using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartUInt_1_ThreadStartUInt_1_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartUInt_1_ThreadStartUInt_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartUInt_1\\ThreadStartUInt_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
