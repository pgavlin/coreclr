using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_threadstart_GThread04_GThread04_
    {
        [OuterLoop]
        [Fact]
        public void _generics_threadstart_GThread04_GThread04_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\threadstart\\GThread04\\GThread04.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
