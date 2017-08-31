using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartString_3_ThreadStartString_3_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartString_3_ThreadStartString_3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartString_3\\ThreadStartString_3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
