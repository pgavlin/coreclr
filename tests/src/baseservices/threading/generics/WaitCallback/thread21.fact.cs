using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_WaitCallback_thread21_thread21_
    {
        [OuterLoop]
        [Fact]
        public void _generics_WaitCallback_thread21_thread21_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\WaitCallback\\thread21\\thread21.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
