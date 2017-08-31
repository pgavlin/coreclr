using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartChar_ThreadStartChar_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartChar_ThreadStartChar_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartChar\\ThreadStartChar.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
