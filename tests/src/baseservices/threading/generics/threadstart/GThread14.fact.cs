using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_threadstart_GThread14_GThread14_
    {
        [OuterLoop]
        [Fact]
        public void _generics_threadstart_GThread14_GThread14_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\threadstart\\GThread14\\GThread14.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
