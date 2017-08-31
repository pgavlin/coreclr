using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_filter_finally02_try_filter_finally02_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_filter_finally02_try_filter_finally02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-filter-finally02\\try-filter-finally02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
