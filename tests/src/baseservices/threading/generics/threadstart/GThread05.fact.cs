using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_threadstart_GThread05_GThread05_
    {
        [OuterLoop]
        [Fact]
        public void _generics_threadstart_GThread05_GThread05_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\threadstart\\GThread05\\GThread05.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
