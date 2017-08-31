using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartByte_2_ThreadStartByte_2_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartByte_2_ThreadStartByte_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartByte_2\\ThreadStartByte_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
