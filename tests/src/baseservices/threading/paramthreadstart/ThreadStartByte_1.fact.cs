using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartByte_1_ThreadStartByte_1_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartByte_1_ThreadStartByte_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartByte_1\\ThreadStartByte_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
