using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartChar_1_ThreadStartChar_1_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartChar_1_ThreadStartChar_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartChar_1\\ThreadStartChar_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
