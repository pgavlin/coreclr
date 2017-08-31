using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _unittests_GoryManagedPresent_GoryManagedPresent_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_GoryManagedPresent_GoryManagedPresent_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\GoryManagedPresent\\GoryManagedPresent.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
