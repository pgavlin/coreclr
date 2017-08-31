using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartGenerics_ThreadStartGenerics_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartGenerics_ThreadStartGenerics_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartGenerics\\ThreadStartGenerics.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
