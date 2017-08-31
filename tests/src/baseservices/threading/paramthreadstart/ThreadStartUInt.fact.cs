using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartUInt_ThreadStartUInt_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartUInt_ThreadStartUInt_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartUInt\\ThreadStartUInt.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
