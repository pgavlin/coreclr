using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _unittests_Recurse_Recurse_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_Recurse_Recurse_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\Recurse\\Recurse.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
