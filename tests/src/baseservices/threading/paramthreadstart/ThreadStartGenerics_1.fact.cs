using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartGenerics_1_ThreadStartGenerics_1_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartGenerics_1_ThreadStartGenerics_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartGenerics_1\\ThreadStartGenerics_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
