using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartSByte_1_ThreadStartSByte_1_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartSByte_1_ThreadStartSByte_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartSByte_1\\ThreadStartSByte_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
