using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_syncdelegate_GThread01_GThread01_
    {
        [OuterLoop]
        [Fact]
        public void _generics_syncdelegate_GThread01_GThread01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\syncdelegate\\GThread01\\GThread01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
