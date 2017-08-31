using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartChar_2_ThreadStartChar_2_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartChar_2_ThreadStartChar_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartChar_2\\ThreadStartChar_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
