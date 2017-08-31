using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartObject_2_ThreadStartObject_2_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartObject_2_ThreadStartObject_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartObject_2\\ThreadStartObject_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
