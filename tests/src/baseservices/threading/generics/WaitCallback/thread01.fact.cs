using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_WaitCallback_thread01_thread01_
    {
        [OuterLoop]
        [Fact]
        public void _generics_WaitCallback_thread01_thread01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\WaitCallback\\thread01\\thread01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
