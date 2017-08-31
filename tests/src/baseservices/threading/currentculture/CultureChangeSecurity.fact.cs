using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _currentculture_CultureChangeSecurity_CultureChangeSecurity_
    {
        [OuterLoop]
        [Fact]
        public void _currentculture_CultureChangeSecurity_CultureChangeSecurity_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\currentculture\\CultureChangeSecurity\\CultureChangeSecurity.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
