using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_syncdelegate_GThread16_GThread16_
    {
        [OuterLoop]
        [Fact]
        public void _generics_syncdelegate_GThread16_GThread16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\syncdelegate\\GThread16\\GThread16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
