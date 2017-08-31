using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartByte_ThreadStartByte_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartByte_ThreadStartByte_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartByte\\ThreadStartByte.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
