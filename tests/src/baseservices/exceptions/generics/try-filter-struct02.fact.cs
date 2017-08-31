using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_filter_struct02_try_filter_struct02_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_filter_struct02_try_filter_struct02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-filter-struct02\\try-filter-struct02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
