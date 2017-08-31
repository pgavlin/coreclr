using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_syncdelegate_GThread28_GThread28_
    {
        [OuterLoop]
        [Fact]
        public void _generics_syncdelegate_GThread28_GThread28_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\syncdelegate\\GThread28\\GThread28.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
