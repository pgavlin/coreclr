using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_threadstart_GThread25_GThread25_
    {
        [OuterLoop]
        [Fact]
        public void _generics_threadstart_GThread25_GThread25_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\threadstart\\GThread25\\GThread25.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
