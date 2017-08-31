using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _unittests_BaseClass_BaseClass_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_BaseClass_BaseClass_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\BaseClass\\BaseClass.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
