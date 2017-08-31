using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartChar_3_ThreadStartChar_3_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartChar_3_ThreadStartChar_3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartChar_3\\ThreadStartChar_3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
