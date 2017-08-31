using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_Monitor_TryEnter06_TryEnter06_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Monitor_TryEnter06_TryEnter06_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\Monitor\\TryEnter06\\TryEnter06.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
