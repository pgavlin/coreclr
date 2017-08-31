using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_WaitCallback_thread17_thread17_
    {
        [OuterLoop]
        [Fact]
        public void _generics_WaitCallback_thread17_thread17_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\WaitCallback\\thread17\\thread17.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
