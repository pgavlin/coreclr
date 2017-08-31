using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_Monitor_TryEnter05_TryEnter05_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Monitor_TryEnter05_TryEnter05_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\Monitor\\TryEnter05\\TryEnter05.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
