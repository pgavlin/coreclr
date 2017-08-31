using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_Monitor_TryEnter01_TryEnter01_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Monitor_TryEnter01_TryEnter01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\Monitor\\TryEnter01\\TryEnter01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
