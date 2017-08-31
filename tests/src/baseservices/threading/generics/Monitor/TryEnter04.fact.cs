using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_Monitor_TryEnter04_TryEnter04_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Monitor_TryEnter04_TryEnter04_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\Monitor\\TryEnter04\\TryEnter04.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
