using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartSByte_2_ThreadStartSByte_2_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartSByte_2_ThreadStartSByte_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartSByte_2\\ThreadStartSByte_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
