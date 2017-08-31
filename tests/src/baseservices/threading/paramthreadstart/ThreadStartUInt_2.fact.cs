using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartUInt_2_ThreadStartUInt_2_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartUInt_2_ThreadStartUInt_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartUInt_2\\ThreadStartUInt_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
