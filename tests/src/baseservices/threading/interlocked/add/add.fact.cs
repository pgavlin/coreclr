using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_add_add_add_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_add_add_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\add\\add.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
