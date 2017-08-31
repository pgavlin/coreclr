using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartString_2_ThreadStartString_2_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartString_2_ThreadStartString_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartString_2\\ThreadStartString_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
