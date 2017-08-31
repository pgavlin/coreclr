using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartGenerics_2_ThreadStartGenerics_2_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartGenerics_2_ThreadStartGenerics_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartGenerics_2\\ThreadStartGenerics_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
