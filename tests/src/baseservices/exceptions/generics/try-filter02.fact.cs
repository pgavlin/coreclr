using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_filter02_try_filter02_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_filter02_try_filter02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-filter02\\try-filter02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
