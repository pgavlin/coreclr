using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_syncdelegate_GThread23_GThread23_
    {
        [OuterLoop]
        [Fact]
        public void _generics_syncdelegate_GThread23_GThread23_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\syncdelegate\\GThread23\\GThread23.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
