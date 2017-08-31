using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartSByte_ThreadStartSByte_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartSByte_ThreadStartSByte_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartSByte\\ThreadStartSByte.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
