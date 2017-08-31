using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _unittests_CollidedUnwind_CollidedUnwind_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_CollidedUnwind_CollidedUnwind_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\CollidedUnwind\\CollidedUnwind.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
