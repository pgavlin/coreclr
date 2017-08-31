using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_Monitor_TryEnter03_TryEnter03_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Monitor_TryEnter03_TryEnter03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\Monitor\\TryEnter03\\TryEnter03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
