using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_WaitCallback_thread18_thread18_
    {
        [OuterLoop]
        [Fact]
        public void _generics_WaitCallback_thread18_thread18_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\WaitCallback\\thread18\\thread18.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
