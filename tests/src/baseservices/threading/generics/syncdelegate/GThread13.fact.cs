using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_syncdelegate_GThread13_GThread13_
    {
        [OuterLoop]
        [Fact]
        public void _generics_syncdelegate_GThread13_GThread13_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\syncdelegate\\GThread13\\GThread13.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
